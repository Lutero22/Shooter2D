using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float vida = 3;

    void Awake()
    {
        Destroy(gameObject, vida);
        StartCoroutine(waiter());
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(2);
        Object.Destroy(this.gameObject);
    }
}