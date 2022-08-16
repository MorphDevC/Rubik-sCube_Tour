using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldOfView : MonoBehaviour
{
    public float zoomSpeed = -5.0f;
    public float acceleration;
    public static bool zoom=false;

    void Start()
    {

    }

    void Update()
    {
        float input = Input.GetAxis("Mouse ScrollWheel");
        if (input != 0)
        {
            if (!zoom && Camera.main.fieldOfView - (input * zoomSpeed) <= 120.0f && Camera.main.fieldOfView - (input * zoomSpeed) >= 50.0f)
                Camera.main.fieldOfView -= input * zoomSpeed*acceleration;
            else if(zoom && Camera.main.fieldOfView - (input * zoomSpeed) <= 120.0f && Camera.main.fieldOfView - (input * zoomSpeed) >= 0f)
                Camera.main.fieldOfView -= input * zoomSpeed * acceleration;
        }
    }
}
