using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScr : MonoBehaviour
{
    float distancia, estimado;
    public Text dist, est;

    void Start()
    {
        
    }

    void Update()
    {
        distancia = PlayerPrefs.GetFloat("Dist");
        estimado = PlayerPrefs.GetFloat("Est");
        dist.text = distancia.ToString();
        est.text = estimado.ToString();
    }

}
