using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimHandGrab : MonoBehaviour
{
    public GameObject collidingObject; // taking note of what we're touching (so we can grab it with mouse button)

    public GameObject heldObject; // REmembering what we're holding so we know what to drop (when we want to drop)

    public float throwForce = 15f;

    // Detect what we just touched
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Rigidbody>() != null) // If you have a rigidbody... 
        {
            collidingObject = other.gameObject; // IT is a gameobject with a rigidbody, so we can take note so can grab it (if we want)
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == collidingObject) // Jsut in case touching more than 1 object with rigidbody
        {
            collidingObject = null; // "Forget" what we were just touching
        }
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0)) // GetKeyDown returns true *at the moment* when mouse button pressed
        {
            if (collidingObject != null) // If we touching something
            {
                Grab();
            }
        }
        else if(Input.GetKeyDown(KeyCode.Mouse1)) // Throw
        {
            if (heldObject != null) // If in fact we holding something
            {
                Release(true);
            }
        }
        else if(Input.GetKeyUp(KeyCode.Mouse0))
        {
            if (heldObject != null) // If in fact we holding something
            {
                Release(false);
            }
        }
    }

    void Grab()
    {
        collidingObject.GetComponent<Rigidbody>().isKinematic = true; // Held object not respond to gravity and forces

        collidingObject.transform.parent = transform; // MAke collidingObject the child of our hand

        heldObject = collidingObject; // to remember what we are holding
    }

    void Release(bool toThrow) 
    {
        Rigidbody heldRb = heldObject.GetComponent<Rigidbody>();

        heldRb.isKinematic = false;

        heldObject.transform.parent = null; // Have no parent

        if(toThrow)
        {
            heldRb.AddForce(transform.forward * throwForce, ForceMode.Impulse);
        }

        heldObject = null; // Forget what we were holding
    }
}
