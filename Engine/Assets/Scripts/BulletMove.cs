using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float Speed = 5.0f;
    public float Sageri = 5;

    void Update()
    {
        gameObject.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        if(Vector3.Distance(gameObject.transform.parent.transform.position, gameObject.transform.position) > Sageri)
        {
            this.transform.parent.GetComponent<PlayerController>().Push(gameObject);
        }
    }
}
