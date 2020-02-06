using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceMovement : MonoBehaviour
{
    public Rigidbody myRb;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            myRb.AddForce(Vector3.forward * 30f * Time.fixedDeltaTime); // A push force
        }
        else if (Input.GetKey(KeyCode.S))
        {
            myRb.AddForce(Vector3.back * 30f * Time.fixedDeltaTime); // A push force
        }

        if (Input.GetKey(KeyCode.A))
        {
            myRb.AddForce(Vector3.left * 30f * Time.fixedDeltaTime); // A push force
        }
        else if (Input.GetKey(KeyCode.D))
        {
            myRb.AddForce(Vector3.right * 30f * Time.fixedDeltaTime); // A push force
        }
    }
}
