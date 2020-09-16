using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlleyColour : MonoBehaviour
{

    //public Material AlleyColours;

    private void Start()
    {
        Colour();
        GameObject.Find("Plane").GetComponent<Renderer>().material.color = CompManager.control.AlleyColour;

    }

    private void Update()
    {

    }

    public void Colour()
    {
        GameObject.Find("Plane").GetComponent<Renderer>().material.color = CompManager.control.AlleyColour;
    }


}