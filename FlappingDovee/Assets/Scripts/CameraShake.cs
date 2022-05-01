using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    private float shakePower = 1f;
    private float shakeTime;
    private Vector3 initialPosition;
    private bool shake;

    CameraShake cameraShake;

    void Start()
    {
        cameraShake = GameObject.FindWithTag("MainCamera").GetComponent<CameraShake>();
        initialPosition = transform.position;
    }

    void Update()
    {
        if(shake)
        {
            transform.position = Random.insideUnitSphere * shakePower + initialPosition;
            shakeTime -= Time.deltaTime;
        }
        if(shakeTime <= 0)
        {
            shakeTime = 0.0f;
            shake = false;
            transform.position = initialPosition;
        }
    }

    public void Initialize()
    {
        transform.position = initialPosition;
        shakeTime = 1f;
        shake = false;
    }

    public void ShakeCamera()
    {
        shake = true;
    }
}
