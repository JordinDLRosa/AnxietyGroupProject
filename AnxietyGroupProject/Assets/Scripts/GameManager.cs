using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    
    public GameObject Negative;
    public GameObject Positive;
    //public GameObject square;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //timer = t++;

        Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
        Vector2 pos = new Vector2(Random.Range(-7.0f, 7.0f), Random.Range(-7.0f, 6.0f));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Negative, pos, Quaternion.identity);
        }

        else if (Input.GetMouseButtonDown(0))
        {
            Instantiate(Positive, worldPosition, Quaternion.identity);
      
        }
    }
}