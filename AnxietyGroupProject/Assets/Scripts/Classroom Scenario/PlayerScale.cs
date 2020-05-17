using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerScale : MonoBehaviour
{
    public float speed = 20f;
    Vector3 temp;
    public Text nameText;
    void Update()
    {
        
        
        if (nameText.text == ("Samantha's Mind"))
        {
            temp = transform.localScale;
            temp.x -= Time.deltaTime;
            temp.y -= Time.deltaTime;
            transform.localScale = temp;
        }
        
    }
}
