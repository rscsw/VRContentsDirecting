using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayButton : MonoBehaviour
{
    public UnityEvent OnPlay;

    public void GamePlayButton()
    {
        Time.timeScale = 1;
        OnPlay.Invoke();
        gameObject.SetActive(false);
    }

    public void Pause()
    {
        gameObject.SetActive(true);
    }
}
