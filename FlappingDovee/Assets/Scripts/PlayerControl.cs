using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerControl : MonoBehaviour
{
    public UnityEvent OnInitialize;
    public UnityEvent OnGameReady;
    public UnityEvent OnGameStart;
    public UnityEvent OnGetScoreSign;
    public UnityEvent OnGameOverSign;

    public void Initialize() //GameManager - OnInitialize
    {
        OnInitialize.Invoke();
        gameObject.SetActive(false);
    }

    public void GameReady() //GameManager - OnGameReady
    {
        gameObject.SetActive(true);
    }

    public void GameStart() //GameManager - OnGameStart
    {
        OnGameStart.Invoke();
    }

    public void GetScoreSign() //GameManager - OnGetScore
    {
        OnGetScoreSign.Invoke();
    }

    public void GameOverSign() //GameManager - OnGameOver
    {
        OnGameOverSign.Invoke();
    }
}
