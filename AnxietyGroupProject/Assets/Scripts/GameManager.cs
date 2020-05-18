using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    GameObject Text1Prefab;
    GameObject Positive1Prefab;

    // Start is called before the first frame update
    void Start()
    {
        Text1Prefab = Resources.Load<GameObject>("Text1") as GameObject;
        Positive1Prefab = Resources.Load<GameObject>("Positive1") as GameObject;

    }

    // Update is called once per frame
    void Update()
    {


        Vector2 pos = new Vector2(Random.Range(-7.0f, 7.0f), Random.Range(-7.0f, 4.0f));
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Text1Prefab, pos, Quaternion.identity);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                Debug.Log("Something was clicked!");
                Debug.Log(hit.collider.gameObject.name);
                GameObject.Destroy(hit.collider.gameObject);
                Instantiate(Positive1Prefab, mousePos2D, Quaternion.identity);
            }

        }
    }
}