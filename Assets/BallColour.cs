using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColour : MonoBehaviour
{

    public Material colour;

    private void Start()
    {
        //Colour();
        GameObject.Find("BowlingBall").GetComponent<Renderer>().material.color = CompManager.control.Colour;

    }

    private void Update()
    {

    }

    public void Colour()
    {
        GameObject.Find("BowlingBall").GetComponent<Renderer>().material.color = CompManager.control.Colour;  
    }


}
