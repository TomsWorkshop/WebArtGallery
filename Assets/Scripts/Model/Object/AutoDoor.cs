using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AutoDoor : MonoBehaviour
{

  // SphereCollider sensor = this.Sensor.GetComponent<SphereCollider>(); 
   /*
void OnTriggerStay(Collider collision)
{            
   //float x = 3.5;
   //this.transform.position = new Vector3(2,2,0);
   Vector3.Lerp(new Vector3(1.6f, 1.25f, 0), new Vector3(3.5f, 1.25f, 0), Time.deltaTime);
}

// Update is called once per frame
void OntriggerExit(Collider collision)
{
   // this.gameObject.transform.Translate(1.6f, 1.25f, 0);
}
*/



 void Update()
   {
       // void OnTriggerEnter (Collider collision) 
       // {             
            transform.localPosition = Vector3.Lerp(transform.localPosition, new Vector3(2.0f, 0, 0), 0.06f);   
          //  transform.localPosition = Vector3.Lerp(transform.localPosition, new Vector3(1.6f, 1.25f, 0), 0.06f);
//        }
   }

}



