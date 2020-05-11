using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCircles : MonoBehaviour
{

    public GameObject EveryonePrefab;
    public float spawnWait;
    public int startWait;
    public bool stop;

    public int circleSpawned = 0;
    public int maxCircles;

    int randCircle;
    // Start is called before the first frame update
    public void Start()
    {
        StartCoroutine(RandomCircle());
    }

    // Update is called once per frame
    void Update()
    {
        if (maxCircles <= circleSpawned)
        {
            stop = true;
        }
        else
        {
            stop = false;
        }
        
    }

    IEnumerator RandomCircle()
    {
        yield return new WaitForSeconds(startWait);

        while (!stop)
        { 
            Vector3 spawnPos = new Vector3(Random.Range(0f, 1000f), Random.Range(0f, 320f), 1);

            Instantiate(EveryonePrefab, spawnPos + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

            yield return new WaitForSeconds(spawnWait);
        }
    }
}
