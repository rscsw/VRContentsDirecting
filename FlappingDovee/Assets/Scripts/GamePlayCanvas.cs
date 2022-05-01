using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GamePlayCanvas : MonoBehaviour
{
    public UnityEvent OnInitialize;
    public UnityEvent OnGetScore;
    public UnityEvent OnPause;
    public UnityEvent OnPlay;

    public void Initialize() //CanvasControl - OnInitialize
    {
        OnInitialize.Invoke();
        gameObject.SetActive(false);
    }
    
    public void GameReady() //CanvasControl - OnGameReady
    {
        gameObject.SetActive(true);
    }

    public void GetScore()
    {
        OnGetScore.Invoke();
    }

    public void GameOver()
    {
        gameObject.SetActive(false);
    }

    public void Pause()
    {
        OnPause.Invoke();
    }

    public void Play()
    {
        OnPlay.Invoke();
    }
}
