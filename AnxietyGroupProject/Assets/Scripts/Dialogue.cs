using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    public string name; //For the characters
    public string player;
    public string mind;
    public string classmates;
    [TextArea(2,14)]
    public string[] sentences; //Sentences that load into the queue
}
