using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Escalator2 : MonoBehaviour
{
    public enum StairType
    {
        UpStairs,
        DownStairs
    }
    [SerializeField] private StairType stairType;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;
        Vector3 step = myTransform.localPosition;
        
        switch(stairType)
        {
            case StairType.UpStairs:
                if(step.x < 1.5f){
                    step.x += 0.01f;
                }
                if(step.x >= 1.5f && step.x < 7.2){
                    step.x += 0.01f;
                    step.y += 0.01f;
                    step.z += 0.0f;
                }
                if(step.x >= 7.2 && step.x < 8.7){
                    step.x +=0.01f;
                }
                transform.localPosition = step;
                return;

            case StairType.DownStairs:
                if(Math.Abs(step.x) < 1.5f){
                    step.x -=0.01f; 
                }
                if(Math.Abs(step.x) >= 1.5f && Math.Abs(step.x) < 7.2){
                    step.x -= 0.01f;
                    step.y -= 0.01f;
                    step.z -= 0.0f;
                }
                if(Math.Abs(step.x) >= 7.2 && Math.Abs(step.x) < 8.7){
                    step.x -=0.01f;
                }
                transform.localPosition = step;
                return;
                
            default:
                return;
        }

        

    }
}
