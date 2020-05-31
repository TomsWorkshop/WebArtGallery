using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2.0f;
    [SerializeField] private float turnSpeed = 30.0f;
    [SerializeField] private VariableJoystick MoveJoystick;
    [SerializeField] private VariableJoystick TurnJoystick;

    private GameObject Head;

    // Start is called before the first frame update
    void Start()
    {
        Head = GameObject.Find("Head");
    }

    // Update is called once per frame
    void Update()
    {
        // Keyboard
        if (!Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(Vector3.forward * Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed);
            transform.Translate(Vector3.right * Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed);
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            Head.transform.Rotate(Vector3.left * Input.GetAxis("Vertical")*Time.deltaTime*turnSpeed);
            transform.Rotate(Vector3.up * Input.GetAxis("Horizontal")*Time.deltaTime*turnSpeed);
        }

        // Joystick
        transform.Translate(Vector3.forward * MoveJoystick.Vertical*Time.deltaTime*moveSpeed);
        transform.Translate(Vector3.right * MoveJoystick.Horizontal*Time.deltaTime*moveSpeed);
        Head.transform.Rotate(Vector3.left * TurnJoystick.Vertical*Time.deltaTime*turnSpeed);
        transform.Rotate(Vector3.up * TurnJoystick.Horizontal*Time.deltaTime*turnSpeed);
    }
}
