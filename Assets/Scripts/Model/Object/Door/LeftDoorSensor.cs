using UnityEngine;

public class LeftDoorSensor : MonoBehaviour
{
    [SerializeField] private GameObject controller;

    void OnTriggerStay(Collider collision)
    {
        controller.GetComponent<LeftDoorController>().isSensorOn = true;
    }

    private void OnTriggerExit(Collider collision)
    {
        controller.GetComponent<LeftDoorController>().isSensorOn = false;
    }
}
