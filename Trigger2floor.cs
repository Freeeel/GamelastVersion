using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger2floor : MonoBehaviour
{
    public bool check = false;


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && check == true)
        {
            SceneManager.LoadScene("SecondGame");
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
