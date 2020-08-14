using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScr : MonoBehaviour
{
    public GameObject bullet;
    float estimado = 0.0f, max=0.0f, min = 0.0f;

    public GameObject win, lose, main;

    public void FireBullet(){
        GameObject bulletIns = Instantiate(bullet, transform.position, transform.rotation);    
        bulletIns.GetComponent<Rigidbody2D>().AddForce(transform.right * canonScr.velo);
        StartCoroutine(Juez());
    }

    IEnumerator Juez(){
        yield return new WaitForSeconds(5.0f);
        max = PlayerPrefs.GetFloat("Dist")+ 1;
        min = PlayerPrefs.GetFloat("Dist") - 1;
        estimado = PlayerPrefs.GetFloat("Est");
        if ( estimado < min || estimado > max){
            lose.SetActive(true);
            main.SetActive(false);
        }
        else {
            win.SetActive(true);
            main.SetActive(false);           
        } 
    }
}
