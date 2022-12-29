using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnity : MonoBehaviour
{
    public Dialogues dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<ManagerEnity>().StartDialogue(dialogue);
    }
}
