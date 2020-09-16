using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompManager : MonoBehaviour
{

    public static CompManager control;
    public Color Colour;
    public Color AlleyColour;

    private void Awake()
    {
        control = this;
        DontDestroyOnLoad(transform.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Ball is " + Colour);
        Debug.Log("Alley is " + AlleyColour);

    }


}


