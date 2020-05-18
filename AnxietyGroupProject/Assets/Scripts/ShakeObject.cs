using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeObject : MonoBehaviour
{
    private bool shaking = false;
    public float shakeAmt;

    // Update is called once per frame
    void Update()
    {
        if (shaking)
        {
            Vector3 newPos = Random.insideUnitSphere * (Time.deltaTime * shakeAmt);
            newPos.y = transform.position.y;
            newPos.z = transform.position.z;
        }
    }
    public void ShakePos()
    {
        StartCoroutine("ShakeNow");
    }
    IEnumerator ShakeNow()
    {
        Vector3 originalPos = transform.position;

        if(shaking == false)
        {
            shaking = true;
        }

        yield return new WaitForSeconds(0.25f);

        shaking = false;
        transform.position = originalPos;

    }
}
