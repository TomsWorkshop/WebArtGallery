using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour {

void OnTriggerStay(Collider coll){
 if(coll.tag=="Player"){
	 GetComponent<Animator>().Play("Door_open");
	 this.enabled=false;
 }
}
void OnTriggerExit(Collider coll){
 if(coll.tag=="Player"){
	 GetComponent<Animator>().Play("Door_close");
	 this.enabled=false;
 }
}

}
