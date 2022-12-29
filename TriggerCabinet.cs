using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerCabinet : MonoBehaviour
{
    public bool check2 = false;


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && check2 == true)
        {
            SceneManager.LoadScene("Cabinet");
        }
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            check2 = true;
        }
    }


    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            check2 = false;
        }
    }
}
