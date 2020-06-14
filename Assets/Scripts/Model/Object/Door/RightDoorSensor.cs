using UnityEngine;

public class RightDoorSensor : MonoBehaviour
{
    [SerializeField] private GameObject controller;

    void OnTriggerStay(Collider collision)
    {
        controller.GetComponent<RightDoorController>().isSensorOn = true;
    }

    private void OnTriggerExit(Collider collision)
    {
        controller.GetComponent<RightDoorController>().isSensorOn = false;
    }
}
