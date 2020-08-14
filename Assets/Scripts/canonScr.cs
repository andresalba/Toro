using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class canonScr : MonoBehaviour
{

    public InputField AngIf, VelIf, DisIf;
    public GameObject warn1;

    float ang = 0.0f, vel = 0.0f, dis = 0.0f;
    public static float velo = 0.0f;

    void Start()
    {
        AngIf.text = "0";
    }

    void Update()
    {
        Angulo();
        Velocidad();
        Estimado();
    }

    void Angulo()
    {
        if(AngIf.text=="")
        {
            ang = 0.0f;
        }
        else
        {
            ang = float.Parse(AngIf.text);
            if(ang > 90 || ang <0)
            {
                warn1.SetActive(true);
            }
            else
            transform.eulerAngles = new Vector3(0.0f, 0.0f, ang);
        }
    }

    void Velocidad()
    {
        if(VelIf.text=="")
        {
            vel = 0.0f;
        }
        else
        {
            vel = float.Parse(VelIf.text);
            velo = vel;
        }
    }

    void Estimado()
    {
        if(DisIf.text=="")
        {
            dis = 0.0f;
        }
        else
        {       
            dis = float.Parse(DisIf.text);
            PlayerPrefs.SetFloat("Est", dis);
        }
    }
}
