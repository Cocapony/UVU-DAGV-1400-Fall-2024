using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    private Rigidbody rb;

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision detected with " + other.gameObject.name);
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.left * 600);
    }
}