using UnityEngine;

public class getParam : MonoBehaviour
{
    public Vector3 m_accel;
    public Gyroscope m_gyro;

    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true;
    }

    private void Update()
    {
        m_accel = Input.acceleration;
        m_gyro  = Input.gyro;
    }

    private void OnGUI()
    {
        var AccRect = new Rect(30, 30, 500, 50);
        var GyroRect = new Rect(30, 60, 500, 50);
        var AttitudeRect = new Rect(30, 90, 500, 50);
        var RPYRect = new Rect(30, 120, 500, 50);

        GUI.skin.label.fontSize = 20;
        GUI.Label(AccRect, string.Format("Acceleration : X={0:F2}, Y={1:F2}, Z={2:F2}",
            m_accel.x, m_accel.y, m_accel.z));
        GUI.Label(GyroRect, string.Format("Gyro : X={0:F2}, Y={1:F2}, Z={2:F2}",
            m_gyro.rotationRate.x, m_gyro.rotationRate.y, m_gyro.rotationRate.z));
        GUI.Label(AttitudeRect, string.Format("Attitude : X={0:F2}, Y={1:F2}, Z={2:F2}, W={2:F2}",
            m_gyro.attitude.x, m_gyro.attitude.y, m_gyro.attitude.z, m_gyro.attitude.w));
        GUI.Label(RPYRect, string.Format("RPY : Roll={0:F2}, Pitch={1:F2}, Yaw={2:F2}",
            m_gyro.attitude.eulerAngles.x, m_gyro.attitude.eulerAngles.y, m_gyro.attitude.eulerAngles.z));
    }
}
