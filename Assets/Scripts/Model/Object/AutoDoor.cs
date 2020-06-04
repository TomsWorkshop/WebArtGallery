using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AutoDoor : MonoBehaviour
{
 void Trans()
 {
                    
            transform.localPosition = Vector3.Lerp(transform.localPosition, new Vector3(2.0f, 0, 0), 0.06f);   
          //  transform.localPosition = Vector3.Lerp(transform.localPosition, new Vector3(1.6f, 1.25f, 0), 0.06f);
 }  
    

}




