using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RetryButton : MonoBehaviour
{
    public UnityEvent OnInitializeSign;

    public void GameRetryButton()
    {
        OnInitializeSign.Invoke();
    }
}
