using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportTrigger : MonoBehaviour
{
    public bool check1 = false;


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && check1 == true)
        {
            SceneManager.LoadScene("SecondGame");
        }
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            check1 = true;
        }
    }


    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            check1 = false;
        }
    }
}

