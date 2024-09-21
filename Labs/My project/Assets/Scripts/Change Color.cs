using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private Renderer objectRenderer;
    private Color[] colors = { UnityEngine.Color.red,UnityEngine.Color.green,UnityEngine.Color.blue};
    private int currentColorIndex = 0;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        if (objectRenderer == null)
        {
            Debug.LogError("Renderer not found in this object. Please attach a Renderer to Component.");
        }    
    }

    void OnCollisionEnter(Collision collision)
    {
        // Change to the next color
        currentColorIndex = (currentColorIndex + 1) % colors.Length;
        objectRenderer.material.color = colors[currentColorIndex];
    }
}