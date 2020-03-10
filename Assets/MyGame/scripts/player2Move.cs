using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKey("i"))
        {
            rb.AddForce(-.5f, 0f, 0f, ForceMode.Impulse);
        }
        if (Input.GetKey("p"))
        {
            rb.AddForce(.5f, 0f, 0f, ForceMode.Impulse);
        }
        if (Input.GetKeyDown("o"))
        {
            jump();
        }
    }

    void jump()
    {
        rb.AddForce(0f, 5f, 0f, ForceMode.Impulse);
    }
}
