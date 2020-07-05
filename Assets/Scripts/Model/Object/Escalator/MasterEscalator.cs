using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MasterEscalator : MonoBehaviour
{
    public GameObject originObject; //オリジナルのオブジェクト
    public float timeOut = 0.9f;
    private float timeElapsed;
    public GameObject clone;
    
    void Update() 
    {
        timeElapsed += Time.deltaTime;

        if(timeElapsed >= timeOut)
        {
            Instantiate(originObject, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
            timeElapsed = 0.0f;

            clone = GameObject.Find("Stair(Clone)");
            Vector3 clones = clone.transform.localPosition;
            
            if(Math.Abs(clones.x) > 8.7)
            {
            Destroy(clone.gameObject);
            }
        }
        
    }
}
