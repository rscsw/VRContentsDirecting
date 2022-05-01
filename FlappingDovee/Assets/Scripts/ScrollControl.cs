using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollControl : MonoBehaviour
{
    public float scrollSpeed;

    private float targetOffset;
    private Renderer rd;
    private int st;
    private float _scrollSpeed;

    void Awake()
    {
        _scrollSpeed = scrollSpeed;
    }

    void Start()
    {
        rd = GetComponent<Renderer>();
    }

    void Update()
    {
        targetOffset += Time.deltaTime * scrollSpeed;
        rd.material.mainTextureOffset = new Vector2(targetOffset, 0);
        if(st == 3)
        {
            scrollSpeed -= 0.0003f;
        }
        if(st == 2)
        {
            scrollSpeed += 0.0004f;
            if(scrollSpeed > 0)
            {
                scrollSpeed = 0;
            }
        }
    }

    public void Initialize()
    {
        scrollSpeed = _scrollSpeed;
        st = 0;
        
    }

    public void GameReady()
    {
        st = 3;
    }

    public void GameStart()
    {
        st = 1;
    }

    public void GameOver()
    {
        st = 2;
    }
}
