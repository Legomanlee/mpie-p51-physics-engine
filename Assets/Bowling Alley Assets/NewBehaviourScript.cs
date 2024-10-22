using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float power = 0;
    public float spin = 0;

    // Update is called once per frame
    void Update()
    {   

        if(Input.GetKey("w")){
            if (power <= 1500){
                power = power + 1;
            }
        }

        if(Input.GetKey("s")){
            if (power >= 1){
                power = power - 1;
            }
        }

        if(Input.GetKey("q")){
            if (spin >= -180){
                spin = spin + 1;
            }
        }

        if(Input.GetKey("e")){
            if (spin <= 180){
                spin = spin - 1;
            }
        }

        if(Input.GetKey("space")){
            Rigidbody rb = GetComponent<Rigidbody> ();
            rb.AddForce(new Vector3 (0.0f, 0.0f, -power * 0.01f));
        }

        float angle = Input.GetAxis("Horizontal");
        float newAngle = angle * Time.deltaTime;

        Transform t = gameObject.transform;
        t.Translate (-newAngle * 0.25f, 0.0f, 0.0f);
        t.Rotate (spin * 0.01f, 0.0f, spin * 0.01f);
    }
}
