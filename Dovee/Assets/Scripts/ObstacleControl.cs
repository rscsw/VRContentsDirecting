using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleControl : MonoBehaviour
{
    public GameObject Obstacle;
    public float spawnTime = 2.0f;
    private Queue<GameObject> ObjPool;
    private int st;

    void Update()
    {
        if(st == 1)
        {
            spawnTime += Time.deltaTime;
            if(spawnTime > 2)
            {
                GameObject obj = Pop();
                obj.SetActive(true);
                spawnTime = 0;
            }
        }
    }

    public void Initialize()
    {
        st = 0;
        gameObject.SetActive(false);
        ObjPool = new Queue<GameObject>();
        for (int i = 0; i < 20; i++)
        {
            GameObject obstaclePool = Instantiate(Obstacle, gameObject.transform.position, Quaternion.identity);
            obstaclePool.transform.parent = gameObject.transform;
            obstaclePool.SetActive(false);
            ObjPool.Enqueue(obstaclePool);
        }
    }

    public void GameStart()
    {
        st = 1;
        gameObject.SetActive(true);
    }

    public GameObject Pop()
    {
        return ObjPool.Dequeue();
    }

    public void Push(GameObject obj)
    {
        obj.SetActive(false);
        obj.transform.position = this.transform.position;
        ObjPool.Enqueue(obj);
    }

    public void GameOver()
    {
        st = 2;
    }
}
