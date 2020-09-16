using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    public static ScoreBoard control;
    public GameObject scoretext;
    public int score = 0;

    private void Awake()
    {
        control = this;
    }

    private void Start()
    {
        scoretext.GetComponent<Text>().text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.GetComponent<Text>().text = "Score: " + score;
    }

    void React()
    {
        score++;
    }
}
