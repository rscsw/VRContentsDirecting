using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameReadyCanvas : MonoBehaviour
{
    public UnityEvent OnInitialize;
    public UnityEvent OnGameReady;
    public UnityEvent OnGameStartSign;

    public void Initialize() //CanvasControl - OnInitialize
    {
        OnInitialize.Invoke();
        gameObject.SetActive(false);
    }

    public void GameReady() //CanvasControl - OnGameReady
    {
        gameObject.SetActive(true);
        OnGameReady.Invoke();
    }

    public void GameStartSign()
    {
        OnGameStartSign.Invoke();
    }

    public void GameStart()
    {
        gameObject.SetActive(false);
    }
}
