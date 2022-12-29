using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorDialogueEnity : MonoBehaviour
{
    public Animator StartAnim;
    public ManagerEnity dm;
    public GameObject TriggerEnity;

    public void OnTriggerEnter2D(Collider2D other)
    {
        StartAnim.SetBool("StartOpen", true);
    }


    public void OnTriggerExit2D(Collider2D other)
    {
        StartAnim.SetBool("StartOpen", false);
        dm.EndDialogue();
        Destroy(TriggerEnity);
        Enity.speed = 0.020f;
    }
}
