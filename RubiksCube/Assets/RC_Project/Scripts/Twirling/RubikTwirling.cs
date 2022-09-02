using UnityEngine;

public class RubikTwirling : ObjectTwirlingFloat
{
    private Vector2 rotateXY;
    private Quaternion origRot;
    

    void Start()
    {
        origRot = transform.localRotation;
        base.Start();
    }
    
    private void Update()
    {
        Debug.Log(GetTwirlingValue);
        if (Input.GetAxis("Fire1") > 0)
        {
            rotateXY -= new Vector2((Input.GetAxis("Mouse X") * GetTwirlingValue) % 360, (Input.GetAxis("Mouse Y") * GetTwirlingValue) % 360);
            transform.localRotation = origRot * Quaternion.AngleAxis(rotateXY.x, Vector3.up) * Quaternion.AngleAxis(rotateXY.y, Vector3.left);
        }
    }

    public void RefreshCube()
    {
        transform.eulerAngles = new Vector3(0, 315, 0);
        rotateXY = new Vector2(0, 0);
    }
}