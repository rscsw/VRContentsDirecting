using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum GameState
{
    Title = 0,
    GamePlay = 1,
    GameOver,
    GameReady
}

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager = null;

    public UnityEvent OnInitialize;
    public UnityEvent OnGameReady;
    public UnityEvent OnGameStart;
    public UnityEvent OnGetScore;
    public UnityEvent OnGameOver;

    public GameState state;

    void Awake()
    {
        if(gameManager == null)
        {
            gameManager = this;
            state = GameState.Title;
            Debug.Log("GameManager : Object Creation Complete.");
        }
        else if(gameManager != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        OnInitialize.Invoke();
    }

    public void GameReady() //GameStartButton - OnGameReady
    {
        state = GameState.GameReady;
        OnGameReady.Invoke();
    }

    public void GameStart()
    {
        state = GameState.GamePlay;
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

    public void Initialize()
    {
        OnInitialize.Invoke();
    }
}
