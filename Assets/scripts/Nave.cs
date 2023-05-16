using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    [SerializeField] private float Force;
    [SerializeField] private float radio;
    [SerializeField] private Transform CheckCrash;
    [SerializeField] private LayerMask Asteroide;
    [SerializeField] private GameObject GameOverScreen;

    private Rigidbody2D cuerpo;

    void Start()
    {
        Time.timeScale = 1f;
        cuerpo = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        bool Crash = Physics2D.OverlapCircle(CheckCrash.position, radio, Asteroide);

        if (Input.GetKey(KeyCode.W))
        {
                cuerpo.AddForce(Vector2.up * Force);    
        }

        if (Input.GetKey(KeyCode.S))
        {
            cuerpo.AddForce(Vector2.down * Force);
        }

        if (Input.GetKey(KeyCode.A))
        {
            cuerpo.AddForce(Vector2.left * Force);
        }

        if (Input.GetKey(KeyCode.D))
        {
            cuerpo.AddForce(Vector2.right * Force);
        }

        if (Crash)
        {
            GameOverScreen.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
