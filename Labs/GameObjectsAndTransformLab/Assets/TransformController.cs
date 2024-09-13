using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformController : MonoBehaviour
{
    public float pulseSpeed = 2f;
    public float maxScale = 1.5f;
    public float minScale = 0.5f;
    public GameObject thing;

    void Update()
    {
        // Move the target GameObject
        var x = Mathf.PingPong(Time.time, 4);
        var y = Mathf.PingPong(Time.time, 4);
        var p = new Vector3(x, y, 0);
        transform.position = p;

        // Rotate the target GameObject
        transform.Rotate(new Vector3(30, 60, 30) * Time.deltaTime);

        //Scale the target GameObject
        float scale = Mathf.PingPong(Time.time * pulseSpeed, maxScale - minScale) + minScale;
        transform.localScale = new Vector3(scale, scale, scale);
    }
}

