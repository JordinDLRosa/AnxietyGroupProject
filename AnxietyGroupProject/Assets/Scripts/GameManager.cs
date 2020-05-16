using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
 
    public GameObject Text1Prefab;
    public GameObject Positive1Prefab;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
        Vector2 pos = new Vector2(Random.Range(-7.0f, 7.0f), Random.Range(-7.0f, 6.0f));
        //Vector2 pos2 = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Text1Prefab, pos, Quaternion.identity);
        }
        else if (Input.GetMouseButtonDown(0))
        {
            Instantiate(Positive1Prefab, worldPosition, Quaternion.identity);
            
        }
        

        // Instantiate(Text3Prefab, pos, Quaternion.identity);
        //  Instantiate(Text4Prefab, pos, Quaternion.identity);

    }
}
