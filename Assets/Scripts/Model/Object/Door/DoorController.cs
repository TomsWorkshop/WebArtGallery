using UnityEngine;

public class DoorController : MonoBehaviour
{
    // Inspector上にプルダウンメニュー追加
    public enum DoorType
    {
        NormalDoor,
        SlideDoor
    }
    [SerializeField] DoorType doorType;

    [SerializeField] private GameObject RightJoint;
    [SerializeField] private GameObject LeftJoint;
    [SerializeField] private float RotateRange;
    [SerializeField] private float SlideRange;

    public bool isSensorOn;     // Sensorのトリガが差動したら切り替わる（DoorSensor.csから変更される）
    
    // 初期値（正規化用）
    private Vector3 initialRightJointPosition;
    private Vector3 initialRightJointRotate;
    private Vector3 initialLeftJointPosition;
    private Vector3 initialLeftJointRotate;

    private void Start()
    {
        isSensorOn = false;
        initialRightJointPosition   = RightJoint.gameObject.transform.localPosition;
        initialRightJointRotate     = RightJoint.gameObject.transform.localEulerAngles;
        initialLeftJointPosition    = LeftJoint.gameObject.transform.localPosition;
        initialLeftJointRotate      = LeftJoint.gameObject.transform.localEulerAngles;
    }

    void Update()
    {
        switch (doorType)
        {
            // switchの分岐に文字列は使えない。
            // enumのリストを実装しておくとインデックスで分岐ができる。
            case DoorType.NormalDoor:
                if (isSensorOn)  DoorRotate(RotateRange);    // 引数は目標角
                if (!isSensorOn) DoorRotate(0);
                return;
            case DoorType.SlideDoor:
                if (isSensorOn) DoorSlide(SlideRange);      // 引数は目標移動量
                if (!isSensorOn) DoorSlide(0);
                return;
            default:
                return;
        }
    }

    private void DoorRotate(float targetAngle)
    {
        float speed = (targetAngle - (RightJoint.transform.localEulerAngles.y - initialRightJointRotate.y)) * 0.01f;    // P制御
        RightJoint.transform.Rotate(Vector3.up * speed);
        LeftJoint.transform.Rotate(Vector3.down * speed);
    }

    private void DoorSlide(float targetPosition)
    {
        float speed = (targetPosition + (RightJoint.transform.localPosition.x - initialRightJointPosition.x)) * 0.01f;  // P制御
        RightJoint.transform.Translate(Vector3.left * speed);
        LeftJoint.transform.Translate(Vector3.right * speed);
    }
}
