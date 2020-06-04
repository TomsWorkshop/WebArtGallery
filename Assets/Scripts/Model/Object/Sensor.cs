using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    public GameObject targetObject1;
    public GameObject targetObject2;
    public GameObject targetObject3;


    // Start is called before the first frame update
    void OnTriggerEnter(Collider collision)
    {
        AutoDoor autodoor = targetObject1.GetComponent<AutoDoor>();
      //  autodoor.Trans();
        //targetObject1 = GetComponentInChildren<AutoDoor>();



    }

    
}
