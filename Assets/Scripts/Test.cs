using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int myInteger = 5;

    public string myString = "NA";

    public Transform myTransform;

    public float speed = 3f;

    public Rigidbody myRb;

    // Start is called before the first frame update
    void Start()
    {
        myInteger = 15;

        RichardMethodIsTheBest();
    }

    // Update is called once per frame
    void Update()
    {
        myInteger = myInteger + 1;
        
        if( Input.GetKey(KeyCode.W) )
        {
            myTransform.position = myTransform.position + myTransform.forward * Time.deltaTime * speed;
        }
        else if( Input.GetKey(KeyCode.S) )
        {
            myTransform.position = myTransform.position - myTransform.forward * Time.deltaTime * speed;
        }

        if( Input.GetKey(KeyCode.A) )
        {
            myTransform.position = myTransform.position - myTransform.right * Time.deltaTime * speed;
        }
        else if( Input.GetKey(KeyCode.D) )
        { 
            transform.position = transform.position + myTransform.right * Time.deltaTime * speed;
        }
        
        transform.Rotate(Vector3.up, Input.GetAxis("Mouse X"), Space.World);
        transform.Rotate(Vector3.left, Input.GetAxis("Mouse Y"), Space.Self);
    }

    void RichardMethodIsTheBest()
    {
        myString = "Funtimes";
    }
}
