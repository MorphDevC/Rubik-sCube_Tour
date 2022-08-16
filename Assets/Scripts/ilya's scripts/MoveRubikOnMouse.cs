using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRubikOnMouse : MonoBehaviour
{
    

    private Vector2 mouseLook;
    private Vector2 smoothV;
    public float sens = 5.0f;

    GameObject charetcter;
    private Vector2 rotateXY;

    private Quaternion origRot;

    void Start()
    {
        origRot = transform.localRotation;

    }
    void Update()
    {
        if (Input.GetAxis("Fire1") > 0)
        {
            rotateXY -= new Vector2((Input.GetAxis("Mouse X") * sens) % 360, (Input.GetAxis("Mouse Y") * sens) % 360);
            transform.localRotation = origRot * Quaternion.AngleAxis(rotateXY.x, Vector3.up) * Quaternion.AngleAxis(rotateXY.y, Vector3.left);
        }
    }

    public void RefreshCube()
    {
        Debug.Log(gameObject.name);
        transform.eulerAngles = new Vector3(0, 315, 0);
        rotateXY = new Vector2(0, 0);
    }
}