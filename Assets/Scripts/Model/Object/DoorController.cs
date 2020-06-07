using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private GameObject RightDoor;
    private double RightDoorRadius;

    // Start is called before the first frame update
    void Start()
    {
        RightDoorRadius = RightDoor.transform.localScale.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        // RightDoor.transform.Rotate(Vector3.up * Time.deltaTime*200);
        RightDoor.transform.Translate(Vector3.right *0.5f);
        RightDoor.transform.Rotate(Vector3.up * 10.0f);
        // Debug.Log(new Vector3(1,2,3));
    }
}
