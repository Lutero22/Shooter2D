using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField] private GameObject VictoryScreen;

    private void Awake()
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(30);
        VictoryScreen.SetActive(true);
        Time.timeScale = 0f;
    }
}
