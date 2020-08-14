using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetScr : MonoBehaviour
{

    public void Reset(){
        PlayerPrefs.SetFloat("Dist", 0);
        PlayerPrefs.SetFloat("Est", 0);
        Application.LoadLevel("Main");
    }
}
