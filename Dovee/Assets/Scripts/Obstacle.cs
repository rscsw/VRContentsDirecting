using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 5;
    public float distance = 20;

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if(Vector3.Distance(transform.parent.transform.position, transform.position) > distance)
        {
            this.transform.parent.GetComponent<ObstacleControl>().Push(gameObject);
        }
    }

    private void OnEnable()
    {
        transform.position = new Vector3(transform.position.x, Random.Range(-0.85f, 0.85f), transform.position.z);
    }
}
