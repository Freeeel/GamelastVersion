using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorDialogue : MonoBehaviour
{
    public Animator StartAnim;
    public Manager dm;
    public GameObject Trigger;

    public void OnTriggerEnter2D(Collider2D other)
    {
        StartAnim.SetBool("StartOpen", true);
    }


    public void OnTriggerExit2D(Collider2D other)
    {
        StartAnim.SetBool("StartOpen", false);
        dm.EndDialogue();
        Destroy(Trigger);
    }
}
