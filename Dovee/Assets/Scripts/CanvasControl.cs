using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CanvasControl : MonoBehaviour
{
    public UnityEvent OnInitialize;
    public UnityEvent OnGameReadySign;
    public UnityEvent OnGameReady;
    public UnityEvent OnGameStartSign;
    public UnityEvent OnGameStart;
    public UnityEvent OnGetScore;
    public UnityEvent OnGameOver;
    public UnityEvent OnInitializeSign;

    public void Initialize() //GameManager - OnInitialize
    {
        OnInitialize.Invoke();
    }

    public void GameReadySign()
    {
        OnGameReadySign.Invoke();
    }

    public void GameReady() //GameManager - OnGameReady
    {
        OnGameReady.Invoke();
    }

    public void GameStartSign()
    {
        OnGameStartSign.Invoke();
    }

    public void GameStart()
    {
        OnGameStart.Invoke();
    }

    public void GetScore()
    {
        OnGetScore.Invoke();
    }

    public void GameOver()
    {
        OnGameOver.Invoke();
    }

    public void InitializeSign()
    {
        OnInitializeSign.Invoke();
    }
}
