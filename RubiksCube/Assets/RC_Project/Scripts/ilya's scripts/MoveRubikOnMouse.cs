using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRubikOnMouse : MonoBehaviour
{
    

    private Vector2 mouseLook;
    private Vector2 smoothV;
    private float sensitivity = 3.0f;

    GameObject charetcter;
    private Vector2 rotateXY;

    private Quaternion origRot;

    void Start()
    {
        origRot = transform.localRotation;

    }
    public void SetNewSenseCube(string sens)
    {
        sensitivity = float.Parse(sens, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
    }
    void Update()
    {
        if (Input.GetAxis("Fire1") > 0)
        {
            rotateXY -= new Vector2((Input.GetAxis("Mouse X") * sensitivity) % 360, (Input.GetAxis("Mouse Y") * sensitivity) % 360);
            transform.localRotation = origRot * Quaternion.AngleAxis(rotateXY.x, Vector3.up) * Quaternion.AngleAxis(rotateXY.y, Vector3.left);
        }
    }

    public void RefreshCube()
    {
        transform.eulerAngles = new Vector3(0, 315, 0);
        rotateXY = new Vector2(0, 0);
    }
}