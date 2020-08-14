using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideScr : MonoBehaviour
{
    public GameObject warn1;
    public void HideWarning()
    {
        warn1.SetActive(false);
    }
}
