using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
public class PlayerScale : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown ("s"))
        {
            transform.localScale = new Vector3 (3, 3, 1);
        }
        else if(Input.GetKeyDown ("a"))
        {
            transform.localScale = new Vector3 (2, 2, 1);
        }
        
    }
}
