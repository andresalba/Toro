using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectorScr : MonoBehaviour
{

    float distReal = 0.0f;
    bool det = true;

    void Update()
    {
        if (transform.position.y <= -4.0f && det)
        {
            //Debug.Log("cayo");
            distReal = transform.position.x + 7;
            Debug.Log(distReal);
            PlayerPrefs.SetFloat("Dist", distReal);
            det = false;
        }
    }
}
