using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScript : MonoBehaviour
{
    GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
            gm = GameObject.Find("GameManager").GetComponent<GameManager>();
            print(gm.name);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //private object DisappearFromScreen()
    //{
    //    Destroy(gameObject);
    //    gm.SpawnPositive;
    //}
}
