using UnityEngine;
using System.Collections;
using System.Security.Cryptography;

public class ModelController : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * 0.01f;
            anim.SetBool("Walk", true);
        }
        else
        {
            anim.SetBool("Walk", false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 1, 0);   //0,10,0
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0,-1, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            // transform.Rotate(0, 20, 0);      //turn
            transform.position -= transform.forward * 0.01f;
            anim.SetBool("Back", true);
        }
        else
        {
            anim.SetBool("Back", false);
        }


        
    }
}
