using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Dovee : MonoBehaviour
{
    public UnityEvent OnGetScoreSign;
    public UnityEvent OnGameOverSign;

    private float jumpPower = 5.0f;
    private Vector3 lookDerection;
    private Vector3 resetPos;
    private Rigidbody rb;
    private int st;

    Animator ani;
    AudioSource audioSource;
    
    void Start()
    {
        resetPos = gameObject.transform.position;
        rb = GetComponent<Rigidbody>();
        ani = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(st == 1)
        {
            if (Input.GetMouseButtonDown(0) && transform.position.y < 4.0f)
            {
                rb.velocity = new Vector3(0, 0, 0);
                rb.AddForce(0, jumpPower, 0, ForceMode.VelocityChange);
                audioSource.Play();
            }
            lookDerection.z = rb.velocity.y * 10.0f + 20.0f;
            rb.useGravity = true;
        }
        Quaternion R = Quaternion.Euler(lookDerection);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, R, 4.0f);
        if(transform.position.y < -6)
        {
            OnGameOverSign.Invoke();
        }
    }

    public void Initialize() //PlayerControl - OnInitialize
    {
        st = 0;
        rb.useGravity = false;
        gameObject.transform.rotation = Quaternion.Euler(new Vector3 (0, 0, 0));
        gameObject.transform.position = resetPos;
        ani.ResetTrigger("isDead");
        rb.velocity = new Vector3(0, 0, 0);
        lookDerection.z = 0;
        
    }

    public void GameReady() //PlayerControl - OnGameReady
    {
        st = 3;
    }

    public void GameStart() //PlayerControl - OnGameStart
    {
        st = 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Obstacle"))
        {
            st = 2;
            ani.SetTrigger("isDead");
            OnGameOverSign.Invoke();
        }
        else if (other.CompareTag("Goal") && st != 2)
        {
            OnGetScoreSign.Invoke();
        }
    }
}
