using UnityEngine;

public class DoorSensor : MonoBehaviour
{
    [SerializeField] private GameObject controller;

    void OnTriggerStay(Collider collision)
    {
        controller.GetComponent<DoorController>().isSensorOn = true;
    }

    private void OnTriggerExit(Collider collision)
    {
        controller.GetComponent<DoorController>().isSensorOn = false;
    }
}
