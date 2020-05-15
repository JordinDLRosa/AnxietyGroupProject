using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueManager : MonoBehaviour
{
    
    public Text nameText;
    public Text dialogueText;
    public Text playerText;
    public Text mindText;
    public Text classmateText;
    private Queue<string> sentences; //First in First Out. Load new sentences past each queue 
    void Start()
    {
        sentences = new Queue<string>();
    }
    public void StartDialogue(Dialogue dialogue)
    {
        nameText.text = dialogue.name;
        sentences.Clear();
        playerText.text = dialogue.player;


        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
        
        
    }
    void EndDialogue()
    {
        Debug.Log("End of conversation.");
    }
}
