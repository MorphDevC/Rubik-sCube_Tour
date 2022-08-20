using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldOfView : MonoBehaviour
{
    public float zoomSpeed = 5.0f;
    public float max_zoom = 100;
    public float min_zoom = 40 ;

    void Update()
    {
        float input = Input.GetAxis("Mouse ScrollWheel");
        if (input !=0 && Camera.main.fieldOfView - (input * zoomSpeed) > min_zoom && Camera.main.fieldOfView - (input * zoomSpeed) < max_zoom)
            Camera.main.fieldOfView -= (input * zoomSpeed);
    }
}
