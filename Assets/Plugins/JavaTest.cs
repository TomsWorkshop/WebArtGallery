using UnityEngine;
using System.Runtime.InteropServices;

public class JavaTest : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void DeviceRun();

    private void Start()
    {
        DeviceRun();
    }
}