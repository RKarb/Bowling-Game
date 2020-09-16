using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public Rigidbody BowlingBall;
    private List<Vector3> KegelPos;
    private List<Quaternion> KegelRot;
    private Vector3 BallPos;
    private int ResetCount = 0;
    public GameObject GameOutcome;

    void ResetAll()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            var Kegels = GameObject.FindGameObjectsWithTag("Kegel");
            for (int i = 0; i < Kegels.Length; i++)
            {
                var KegelPhysics = Kegels[i].GetComponent<Rigidbody>();
                KegelPhysics.velocity = Vector3.zero;
                KegelPhysics.position = KegelPos[i];
                KegelPhysics.rotation = KegelRot[i];
                KegelPhysics.velocity = Vector3.zero;
                KegelPhysics.angularVelocity = Vector3.zero;

                /*var Ball = GameObject.FindGameObjectWithTag("Ball");
                Ball.transform.position = BallPos;
                Ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
                Ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;*/

                BowlingBall.transform.position = BallPos;
                BowlingBall.velocity = Vector3.zero;
                BowlingBall.angularVelocity = Vector3.zero;
                BowlingBall.constraints = RigidbodyConstraints.FreezePosition;
            }
            ResetCount++;
        }
    }

    void ResetBall()
    {
        if (Input.GetKeyUp(KeyCode.C))
        {
            /*var Ball = GameObject.FindGameObjectWithTag("Ball");
            Ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
            Ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            Ball.transform.position = BallPos;*/

            BowlingBall.transform.position = BallPos;
            BowlingBall.velocity = Vector3.zero;
            BowlingBall.angularVelocity = Vector3.zero;
            BowlingBall.constraints = RigidbodyConstraints.FreezePosition;
        }
    }

  void Close()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void Outcome()
    {
        if(ScoreBoard.control.score >= 18 && ResetCount >= 5)
        {
            GameOutcome.GetComponent<Text>().text = "Congratualtions! you've won!";
            BowlingBall.transform.position = BallPos;
            BowlingBall.velocity = Vector3.zero;
            BowlingBall.angularVelocity = Vector3.zero;
            BowlingBall.constraints = RigidbodyConstraints.FreezePosition;
        }
        else if(ScoreBoard.control.score < 18 && ResetCount >= 5)
        {
            GameOutcome.GetComponent<Text>().text = "whoops, better luck next time!";
            BowlingBall.transform.position = BallPos;
            BowlingBall.velocity = Vector3.zero;
            BowlingBall.angularVelocity = Vector3.zero;
            BowlingBall.constraints = RigidbodyConstraints.FreezePosition;
        }
        else
        {
            GameOutcome.GetComponent<Text>().text = " ";

        }
    }


    // Start is called before the first frame update
    void Start()
    {
        var kegels = GameObject.FindGameObjectsWithTag("Kegel");
        KegelPos = new List<Vector3>();
        KegelRot = new List<Quaternion>();
        foreach (var Kegel in kegels)
        {
            KegelPos.Add(Kegel.transform.position);
            KegelRot.Add(Kegel.transform.rotation);
        }
        BallPos = GameObject.FindGameObjectWithTag("Ball").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        ResetAll();
        ResetBall();
        Close();
        Outcome();
       /* if (Input.GetKeyUp(KeyCode.Space))
        {
            var Kegels = GameObject.FindGameObjectsWithTag("Kegel");
            for(int i = 0, i < Kegels.Length; i++)
            {
                var KegelPhysics = Kegels[i].GetComponent<Rigidbody>();
                KegelPhysics.velocity = Vector3.zero;
                KegelPhysics.position = KegelPos[i];
                KegelPhysics.angularVelocity = Vector3.zero;

                var Ball = GameObject.FindGameObjectWithTag("Ball");
                Ball.transform.position = BallPos;
                Ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
                Ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

            }
        }

        if (Input.GetKeyUp(KeyCode.C))
        {
            var Ball = GameObject.FindGameObjectWithTag("Ball");
            Ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
            Ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            Ball.transform.position = BallPos;
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit;
        }*/
    }
}
