using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int PinScore;

    public Text ScoreText;

    void Start()
    {
        PinScore = 0;
    }

    void Update()
    {
        ScoreText.text = PinScore.ToString();
    }
}
