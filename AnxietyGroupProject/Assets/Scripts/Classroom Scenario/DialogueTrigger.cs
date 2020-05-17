using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue[] dialogues;

    public void TriggerDialogue()
    {
        DialogueManager manager = FindObjectOfType<DialogueManager>();
        manager.setIndex(0);
        manager.StartDialogue(dialogues[0]);
        //index = 0;
        //StartDialogue(conversation[index]);
        //FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        //FindObjectOfType<PlayerDialogue>().StartDialogue(dialogue);
        //FindObjectOfType<MindDialogue>().StartDialogue(dialogue);
        //FindObjectOfType<ClassmatesDialogue>().StartDialogue(dialogue);
    }

} 
