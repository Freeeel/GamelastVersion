using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static bool PauseSet;
    public GameObject PausePanel;
    public AudioSource Button;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(PauseSet)
            {
                Resume();
            }
            else
            {
                PauseMenu();
            }
        }
    }


    public void Resume()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1;
        PauseSet = false;
        Button.Play();
    }


    public void PauseMenu()
    {
        PausePanel.SetActive(true);
        PauseSet = true;
        Button.Play();
    }


    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
        Button.Play();
    }
}
