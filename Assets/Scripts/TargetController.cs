using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetController : MonoBehaviour
{
    public float score; // Default 0
    public Transform center;

    public Text scoreText;

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 hitPoint = collision.GetContact(0).point;

        float distFromCenter = Vector3.Distance(hitPoint, center.position);

        score = score + 1f / (1f + distFromCenter);

        scoreText.text = "Score: " + score;
    }
}