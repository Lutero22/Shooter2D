using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void reiniciar(string Reinicio)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void quit(string QuitApp)
    {
        Application.Quit();
        Debug.Log("App cerrada");
    }
}