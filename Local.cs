using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Local : MonoBehaviour
{
    public void Update()
    {
        if(Player.Death == true && Pause.PauseSet == true)
        {
            Time.timeScale = 0f;
            Player.speed = 0f;
        }
        else if (Player.Death == true || Pause.PauseSet == true)
        {
            Time.timeScale = 0f;
            Player.speed = 0f;
        }
        else if (Player.Death == false && Pause.PauseSet == false)
        {
            Time.timeScale = 1f;
            Player.speed = 1f;
        }
    }
}
