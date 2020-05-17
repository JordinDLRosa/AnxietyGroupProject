using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] //Shows up in the inspector so we can edit it on there
public class Dialogue
{
    public string name; //Speaker's name
    [TextArea(2,14)] //The amount of lines the text area uses
    public string[] sentences; //Sentences that load into the queue
}
