using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escalator : MonoBehaviour
{
    public GameObject stair;
    public GameObject endstep;
    int i;

    void Start()
    {
        
    }

    void Update()
    {
        Transform myTransform = this.transform;
        Vector3 step = myTransform.localPosition; 

        stair = GameObject.Find("Stair3");
        Vector3 stairs = stair.transform.localPosition;

        Debug.Log(stairs);
        Debug.Log(step);
        // this.gameObject.transform.Translate(stairs.x,stairs.y,stairs.z);

        if(step.x < stairs.x){
            step.x += 0.01f;
            step.y += 0.01f;
            step.z += 0.01f;
        }
        // step.x = stairs.x;
        // step.y = stairs.y;
        // step.z = stairs.z;

        transform.localPosition = step;


        endstep = GameObject.Find("Stair4");
        Vector3 endsteps = endstep.transform.localPosition;
        Debug.Log(endsteps);
        if(step.x < endsteps.x){
            step.x += 0.01f;
        }
        transform.localPosition = step;
        
        
    }
}
