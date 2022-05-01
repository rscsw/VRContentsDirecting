using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameOverCanvas : MonoBehaviour
{
    public UnityEvent OnInitializeSign;
    
    public void Initialize()
    {
        gameObject.SetActive(false);
    }

    public void GameOver()
    {
        gameObject.SetActive(true);
    }
    
    public void InitializeSign()
    {
        OnInitializeSign.Invoke();
    }
}
