using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody BowlingBall;
    private bool isDragging = false;
    private Plane dragPlane;
    private Vector3 moveTo;

    float dragDamper = 5.0f;
    float addToY = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        BowlingBall.constraints = RigidbodyConstraints.FreezePosition;
    }

    // Update is called once per frame
    void Update()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        float dist;

        if (Input.GetMouseButtonDown(0))
        {
            BowlingBall.constraints = RigidbodyConstraints.FreezePosition;
            if(Physics.Raycast(ray, out hit))
            {
                if(hit.transform.root.transform == transform)
                {
                    isDragging = true;
                    BowlingBall.useGravity = false;
                    //dragPlane = new Plane(-ray.direction.normalized, hit.point);
                    dragPlane = new Plane(Vector3.up, transform.position + Vector3.up * addToY);
                    BowlingBall.constraints = RigidbodyConstraints.None;
                    BowlingBall.constraints = RigidbodyConstraints.FreezePositionY;
                }
            }
        }

        if (isDragging)
        {
            var hasHit = dragPlane.Raycast(ray, out dist);
            if (hasHit)
            {
                moveTo = ray.GetPoint(dist);
            }
        }

        if(Input.GetMouseButtonUp(0) && isDragging)
        {
            isDragging = false;
            BowlingBall.useGravity = true;
        }

    }

    void FixedUpdate()
    {
        if (isDragging)
        {
            return;
        }

        var velocity = moveTo - transform.position;
        var rotation = new Vector3(BowlingBall.velocity.z, 0, -BowlingBall.velocity.x) * 20;
        BowlingBall.velocity = Vector3.Lerp(BowlingBall.velocity, velocity, dragDamper * Time.deltaTime);
        BowlingBall.angularVelocity = Vector3.Lerp(BowlingBall.angularVelocity, rotation, dragDamper * Time.deltaTime);
        
    }

}
