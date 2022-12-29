using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger1floor : MonoBehaviour
{
    public bool check = false;
    public static bool conva = false;


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && check == true)
        {
            SceneManager.LoadScene("Game");
            conva = !conva;
        }
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            check = true;
        }
    }


    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            check = false;
        }
    }

}
