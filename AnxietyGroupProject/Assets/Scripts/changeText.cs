using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeText : MonoBehaviour
{
	public string playerDialogOption1;
	public string playerDialogOption2;
	public string playerDialogOption3;
	public string playerDialogOption4;

	private int numberOfTimesIHitSpaceBar = 0;
	public Text playerTextBox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
        	numberOfTimesIHitSpaceBar++;

        	if(numberOfTimesIHitSpaceBar ==1)
        	{
        		playerTextBox.text = playerDialogOption1;
        	}
        	else if(numberOfTimesIHitSpaceBar == 2)
        	{
        		playerTextBox.text = playerDialogOption2;
        	}
            else if(numberOfTimesIHitSpaceBar == 3)
            {
                playerTextBox.text = playerDialogOption3;
            }
            else if(numberOfTimesIHitSpaceBar == 4)
            {
                playerTextBox.text = playerDialogOption4;
            }

        }
    }
}
