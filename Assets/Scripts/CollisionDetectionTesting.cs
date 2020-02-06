using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetectionTesting : MonoBehaviour
{
    public GameObject prefab;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("This trigger detects " + other.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name + " left");
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("This collider was hit by " + collision.gameObject.name);

        GameObject clone = Instantiate(prefab, transform.position + Vector3.up * 10f, prefab.transform.rotation);
    }
}
