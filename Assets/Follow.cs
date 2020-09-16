using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{

    Vector3 CamPos = new Vector3(0,7,10);
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + CamPos;
    }
}
