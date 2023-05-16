using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public Transform SpawnBala;
    public GameObject prefabBala;
    public float Velocidad = 10;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(prefabBala, SpawnBala.position, SpawnBala.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = SpawnBala.up * Velocidad;
        }
    }
}
