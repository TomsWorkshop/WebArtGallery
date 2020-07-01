using UnityEngine;

public class DoorSensor : MonoBehaviour
{
    public bool isOpen = false;

    void OnTriggerStay(Collider collision)
    {
        isOpen = true;
        Debug.Log("hit");
    }

    private void OnTriggerExit(Collider collision)
    {
        isOpen = false;
    }
}
