using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerButtonCabinet : MonoBehaviour
{
    public Animator anim;


    public void OnTriggerEnter2D(Collider2D other)
    {
        anim.SetTrigger("ButtonExit");
    }


    public void OnTriggerExit2D(Collider2D other)
    {
        anim.SetTrigger("ButtonExit");
    }
}
