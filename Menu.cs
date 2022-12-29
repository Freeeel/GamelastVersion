using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public GameObject settingsPanel;
    public AudioSource Button;


    public void Start()
    {
        Time.timeScale = 1.0f;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Pause.PauseSet = false;
        Button.Play();
    }

    public void ExitGame()
    {
        Application.Quit();
        Button.Play();
    }

    public void SettingsPanel()
    {
        settingsPanel.SetActive(true);
        Button.Play();
    }


    public void ExitPanel()
    {
        settingsPanel.SetActive(false);
        Button.Play();
    }
}
