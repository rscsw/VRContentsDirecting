using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public Text scoreText;

    private int score = 0;
    private int st = 0;

    void Update()
    {
        if(st == 1)
        {
            scoreText.text = "Score : " + score.ToString();
        }
    }

    public void Initialize()
    {
        st = 0;
        score = 0;
    }

    public void GameStart() //GamePlayCanvas - OnGameStart
    {
        st = 1;
    }

    public void GetScore()
    {
        score++;
    }
}
