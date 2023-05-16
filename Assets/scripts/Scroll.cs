using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    private float VelocidadScroll = 4f;

    void Update()
    {
        transform.Translate(Vector2.up * VelocidadScroll * Time.deltaTime);
    }
}
