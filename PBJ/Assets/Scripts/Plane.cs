using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        GameManager.instance.onGameStart.Invoke();
    }
}
