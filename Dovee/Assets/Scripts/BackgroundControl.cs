using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BackgroundControl : MonoBehaviour
{
    public UnityEvent OnInitialize;
    public UnityEvent OnGameReady;
    public UnityEvent OnGameStart;
    public UnityEvent OnGameOver;

    public List<GameObject> backgroundResourse = new List<GameObject>();

    public void Initialize()
    {
        OnInitialize.Invoke();
        gameObject.SetActive(true);
    }

    public void GameReady()
    {
        OnGameReady.Invoke();
    }

    public void GameStart()
    {
        OnGameStart.Invoke();
    }

    public void GameOver()
    {
        OnGameOver.Invoke();
    }
}
