using UnityEngine;

public class PanelController : MonoBehaviour
{
    public void ActivateSwitch()
    {
        this.gameObject.SetActive(!this.gameObject.activeSelf);
    }
}