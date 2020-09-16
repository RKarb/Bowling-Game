using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColourChanger : MonoBehaviour
{

    public Dropdown Selector;
    public Dropdown AlleySelector;

    // Update is called once per frame
    void Update()
    {
        switch(Selector.value)
        {
            case 0:
                CompManager.control.Colour = Color.red;
                Debug.Log("Red");
                break;
            case 1:
                CompManager.control.Colour = Color.green;
                Debug.Log("Green");
                break;
            case 2:
                CompManager.control.Colour = Color.blue;
                Debug.Log("Blue");
                break;
            case 3:
                CompManager.control.Colour = Color.yellow;
                Debug.Log("Yellow");
                break;

        }

        switch(AlleySelector.value)
        {
            case 0:
                CompManager.control.AlleyColour = Color.red;
                Debug.Log("Red");
                break;
            case 1:
                CompManager.control.AlleyColour = Color.green;
                Debug.Log("Green");
                break;
            case 2:
                CompManager.control.AlleyColour = Color.blue;
                Debug.Log("Blue");
                break;
            case 4:
                CompManager.control.AlleyColour = Color.yellow;
                Debug.Log("Yellow");
                break;
        }
    }
}
