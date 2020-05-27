using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getParam : MonoBehaviour
{
    private Vector3 m_accel;
    private Gyroscope m_gyro;

    // Start is called before the first frame update
    void Start()
    {
        m_accel = Input.acceleration;
        m_gyro  = Input.gyro;
        m_gyro.enabled = true;
    }

    private void Update()
    {
        m_accel = Input.acceleration;
        m_gyro  = Input.gyro;
    }

    private void OnGUI() {
        var AccRect = new Rect(30, 30, 500, 50);
        var GyroRect = new Rect(30,60, 500, 50);
        var AttitudeRect = new Rect(30,90, 500, 50);
        GUI.skin.label.fontSize = 20;
        GUI.Label(AccRect, string.Format("Acceleration : X={0:F2}, Y={1:F2}, Z={2:F2}",
            m_accel.x, m_accel.y, m_accel.z));
        GUI.Label(GyroRect, string.Format("Gyro : X={0:F2}, Y={1:F2}, Z={2:F2}",
            m_gyro.rotationRate.x, m_gyro.rotationRate.y, m_gyro.rotationRate.z));
        GUI.Label(AttitudeRect, string.Format("Attitude : X={0:F2}, Y={1:F2}, Z={2:F2}",
            m_gyro.attitude.x, m_gyro.attitude.y, m_gyro.attitude.z));
    }
}
