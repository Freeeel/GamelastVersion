using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMenu : MonoBehaviour
{
    public AudioSource Button;
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Player.Death = false;
        Button.Play();
    }
    public void ExitMenu()
    {
        SceneManager.LoadScene("Menu");
        Player.Death = false;
        Button.Play();
    }

    public void ExitGame()
    {
        Application.Quit();
        Button.Play();
    }
}
