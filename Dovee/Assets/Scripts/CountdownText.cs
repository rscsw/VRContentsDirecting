using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CountdownText : MonoBehaviour
{

    public Text countdownText;
    public UnityEvent OnGameStartSign;

    public float count;
    public int st;

    void Update()
    {
        if(st == 3)
        {
            count -= Time.deltaTime;
            countdownText.text = count.ToString("N0");
        }
        if(count < 1)
        {
            GameStartSign();
        }
    }

    public void Initialize()
    {
        count = 3f;
        st = 0;
    }

    public void GameReady() //GameReadyCanvas - OnGameReady
    {
        st = 3;
    }

    public void GameStartSign()
    {
        OnGameStartSign.Invoke();
    }
}
