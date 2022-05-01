using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PauseButton : MonoBehaviour
{
    public UnityEvent OnPause;

    public void GamePauseButton()
    {
        Time.timeScale = 0;
        OnPause.Invoke();
        gameObject.SetActive(false);
    }

    public void Play()
    {
        gameObject.SetActive(true);
    }
}
