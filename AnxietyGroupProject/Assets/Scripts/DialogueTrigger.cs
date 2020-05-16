using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        //FindObjectOfType<PlayerDialogue>().StartDialogue(dialogue);
        //FindObjectOfType<MindDialogue>().StartDialogue(dialogue);
        //FindObjectOfType<ClassmatesDialogue>().StartDialogue(dialogue);
    }
   
}
