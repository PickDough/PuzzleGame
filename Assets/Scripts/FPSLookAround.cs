using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FPSLookAround : MonoBehaviour
{
 
    [SerializeField] Transform cam;
    [SerializeField] float sensitivity;
    float headRotation = 0f;
    [SerializeField] private float maxRotation = 90f;

    public void Rotate(float x, float y)
    {
        var xRotation = x * sensitivity * Time.deltaTime;
        var yRotation = y * sensitivity * Time.deltaTime;
        transform.Rotate(0, xRotation, 0);
        
        headRotation += yRotation;
        headRotation = Mathf.Clamp(headRotation, -maxRotation, maxRotation);
        cam.eulerAngles = new Vector3(headRotation, 0f, 0f);
    }
}

