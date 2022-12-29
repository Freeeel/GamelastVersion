using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public Dialogues dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<Manager>().StartDialogue(dialogue);
    }
}
