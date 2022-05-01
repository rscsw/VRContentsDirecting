using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameStartButton : MonoBehaviour
{
    public UnityEvent OnGameReadySign;

    public void GameReadySign()
    {
        OnGameReadySign.Invoke();
    }
}
