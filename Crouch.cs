using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{
    CharacterController characterCollider;
    // Start is called before the first frame update
    void Start()
    {
        characterCollider = gameObject.GetComponent<CharacterController> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            characterCollider.height = 1.0f;
        }
                   
        else
        {
            characterCollider.height = 1.8f;
        }                  
       
    }
}
