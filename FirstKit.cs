using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstKit : MonoBehaviour
{
    public static float lives;
    public bool take;
    public GameObject kit;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && take == true)
        {
            lives = Random.Range(0, 3);
            Player.health += lives;
            Debug.Log(lives);
            Destroy(kit);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            take = true;
        }
    }


    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            take = false;
        }
    }
}
