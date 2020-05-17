using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[System.Serializable] //Shows up in the inspector so we can edit it on there
/*public class Dialogue
{
    public string name; //Speaker's name
    [TextArea(1, 3)] public string[] sentences; //The amount of lines the text area uses
}
*/
public class DialogueManager : MonoBehaviour
{
    public Dialogue[] dialogues;
    public Text nameText, dialogueText;
    private int index = 0;
    private Queue<string> sentences; //First in First Out. Load new sentences past each queue
    void Start()
    {
        DialogueTrigger dialogueTrigger = FindObjectOfType<DialogueTrigger>();
        dialogues = dialogueTrigger.dialogues;
        sentences = new Queue<string>(); //Starts the queue of sentences
    }
    public void StartDialogue(Dialogue dialogue)
    {
        nameText.text = dialogue.name;
        sentences.Clear();

        foreach (string sentence in dialogues[index].sentences)
            sentences.Enqueue(sentence);
        
        DisplayNextSentence();
    }
    public void DisplayNextSentence() //Calls when hits next
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        //Debug.Log(sentence);
        //dialogueText.text = sentence;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        
        
    }
    private void EndDialogue()
    {
        index++;
        if(index < dialogues.Length)
        {
            StartDialogue(dialogues[index]);
            return;
        }
        else
        {
            Debug.Log("End of conversation.");
        }
        
    }
    IEnumerator TypeSentence(string sentence)
    {
        
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }
    public void setIndex(int index)
    {
        this.index = index;
    }
    /*public void TriggerDialogue()
    {
        index = 0;
        StartDialogue(dialogues[index]);
        //FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        //FindObjectOfType<PlayerDialogue>().StartDialogue(dialogue);
        //FindObjectOfType<MindDialogue>().StartDialogue(dialogue);
        //FindObjectOfType<ClassmatesDialogue>().StartDialogue(dialogue);
    }*/
}
