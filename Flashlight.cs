using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public AudioSource click;
    public bool isOn = false;
    public GameObject LightSource;
    public bool failSafe = false; 
    void Update()
    {
       if (Input.GetButtonDown("F"))
        {
            if (isOn == false && failSafe == false)
            {
                failSafe = true;
                LightSource.SetActive(true);
                click.Play();
                isOn = true;
                StartCoroutine(FailSafe());
            }
            if (isOn ==true && failSafe == false)
            {
                failSafe = true;
                LightSource.SetActive(false);
                click.Play();
                isOn = false;
                StartCoroutine(FailSafe());
            }
        }
    }
    IEnumerator FailSafe()
    {
        yield return new WaitForSeconds(0.25f);
        failSafe = false;
    }
}
