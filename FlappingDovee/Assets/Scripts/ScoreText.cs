using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public Text scoreText;

    private int score = 0;

    void Update()
    {
        scoreText.text = "Score : " + score.ToString();
    }

    public void Initialize()
    {
        score = 0;
    }

    public void GetScore()
    {
        score++;
    }
}
