using UnityEngine;

public class CameraJointController : MonoBehaviour
{
    GameObject parentObj;
    [SerializeField] private float HrotateSpeed = 30.0f;
    [SerializeField] private float HangleLimit = 45.0f;
    [SerializeField] private float VrotateSpeed = 20.0f;
    [SerializeField] private float VangleLimit = 15.0f;
    public VariableJoystick variableJoystick;

    private void Start()
    {
        parentObj = transform.parent.gameObject;
    }

    private void Update ()
    {
        // keyboard
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Mathf.Abs(AngleNormalization(parentObj.transform.localEulerAngles.y)) <= HangleLimit)
            {
                float Hangle_ = Input.GetAxis("Horizontal") * HrotateSpeed;
                parentObj.transform.Rotate(Vector3.up * Hangle_*Time.deltaTime);

                if (HangleLimit < AngleNormalization(parentObj.transform.localEulerAngles.y))
                    parentObj.transform.localEulerAngles = Vector3.up * (HangleLimit - 0.1f);
                if (AngleNormalization(parentObj.transform.localEulerAngles.y) < -HangleLimit)
                    parentObj.transform.localEulerAngles = Vector3.up * (-HangleLimit + 0.1f);
            }

            if (Mathf.Abs(parentObj.transform.localEulerAngles.x) <= 90)
            {
                float Vangle_ = Input.GetAxis("Vertical") * VrotateSpeed;
                transform.Rotate(Vector3.right * -Vangle_*Time.deltaTime);

                if (VangleLimit < AngleNormalization(transform.localEulerAngles.x))
                    transform.localEulerAngles = Vector3.right * (VangleLimit - 0.1f);
                if (AngleNormalization(transform.localEulerAngles.x) < -VangleLimit)
                    transform.localEulerAngles = Vector3.right * (-VangleLimit + 0.1f);
            }
        }

        // mobile
        if (Mathf.Abs(AngleNormalization(parentObj.transform.localEulerAngles.y)) <= HangleLimit)
        {
            float Hangle = variableJoystick.Horizontal * HrotateSpeed;
            parentObj.transform.Rotate(Vector3.up * Hangle*Time.deltaTime);

            if (HangleLimit < AngleNormalization(parentObj.transform.localEulerAngles.y))
                parentObj.transform.localEulerAngles = Vector3.up * (HangleLimit - 0.1f);
            if (AngleNormalization(parentObj.transform.localEulerAngles.y) < -HangleLimit)
                parentObj.transform.localEulerAngles = Vector3.up * (-HangleLimit + 0.1f);
        }

        if (Mathf.Abs(parentObj.transform.localEulerAngles.x) <= 90)
        {
            float Vangle = variableJoystick.Vertical * VrotateSpeed;
            transform.Rotate(Vector3.right * -Vangle*Time.deltaTime);

            if (VangleLimit < AngleNormalization(transform.localEulerAngles.x))
                transform.localEulerAngles = Vector3.right * (VangleLimit - 0.1f);
            if (AngleNormalization(transform.localEulerAngles.x) < -VangleLimit)
                transform.localEulerAngles = Vector3.right * (-VangleLimit + 0.1f);
        }
    }

    private float AngleNormalization(float angle)
    {
        if (180 < angle) return angle - 360;
        else return angle;
    }

    public void RotateReset()
    {
        Debug.Log(this.transform.name);
        Debug.Log(this.transform.parent.transform.name);
        this.transform.parent.transform.localEulerAngles = Vector3.zero;
        this.transform.localEulerAngles = Vector3.zero;
    }
}
