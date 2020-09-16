using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.gameObject.tag == "Kegel")
        {
            GameObject.Find("Text").SendMessage("React");
            Debug.Log("score");
        }
    }

}
