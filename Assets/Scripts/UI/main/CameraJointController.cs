using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraJointController : MonoBehaviour
{
    //プレイヤーを変数に格納
    private GameObject CameraObject;
    public float rotateSpeed = 3.0f;

    void Start ()
    {
        CameraObject = this.gameObject;
    }

    void Update ()
    {
        float angle = Input.GetAxis("Horizontal") * rotateSpeed;
        // float angle = Input.acceleration.z * rotateSpeed;
        Vector3 CameraObjectPos = CameraObject.transform.position;
        transform.RotateAround(CameraObjectPos, Vector3.up, angle);
    }
}
