using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TitleCanvas : MonoBehaviour
{
    public UnityEvent OnGameReadySign;

    public void Initialize() //CanvasControl - OnInitialize
    {
        gameObject.SetActive(true);
    }

    public void GameReadySign()
    {
        OnGameReadySign.Invoke();
    }
    
    public void GameReady() //CanvasControl - OnGameReady
    {
        gameObject.SetActive(false);
    }
}
