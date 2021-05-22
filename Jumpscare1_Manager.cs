using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Jumpscare1_Manager : MonoBehaviour
{
    public Transform target;
    public float speed;
    private Jumpscare1 Jumpscare;

    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
      
        if ( Jumpscare.Jumpscarecheck == true)
        {
            float step = speed * Time.deltaTime;

            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            
        }
        else
        {
            return;
        }

    }
    

}
