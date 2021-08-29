using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBehaviour: MonoBehaviour
{
    // Start is called before the first frame update
    private Text thisText;
    private static int score;

    void Start()
    {
        thisText = GetComponent<Text>();
        score = 0;


    }

    // Update is called once per frame
    void Update()
    {
        thisText.text = "score:" + score;
    }
    public static void AddScore()
    {
        score += 10;
    }
}

