using UnityEngine;

public class AvaterController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2.0f;
    [SerializeField] private float turnSpeed = 30.0f;
    public VariableJoystick variableJoystick;

    private void Update()
    {
        // keyboard
        if (!Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(Vector3.forward * Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed);
            transform.Rotate(Vector3.up * Input.GetAxis("Horizontal")*Time.deltaTime*turnSpeed);
        }

        transform.Translate(Vector3.forward * variableJoystick.Vertical*Time.deltaTime*moveSpeed);
        transform.Rotate(Vector3.up * variableJoystick.Horizontal*Time.deltaTime*turnSpeed);
    }
}