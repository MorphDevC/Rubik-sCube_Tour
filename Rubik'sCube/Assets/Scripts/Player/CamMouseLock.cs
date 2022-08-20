
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMouseLock : MonoBehaviour
{
    // Start is called before the first frame update
    
   private float sensitivity = 2.0f;
        

    private Vector2 rotXY;
    private float rotX=0;
    private float rotY = 0;

    private Quaternion originalRot;

    void Start()
    {

        originalRot = transform.localRotation;

    }

    public void SetNewSensivity(string sens)
    {
        
        sensitivity = float.Parse(sens, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);

    }

    // Update is called once per frame
    void Update()
    {
        #region VitalyCamLock
        //var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y")); // Take 2 axes

        //md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        //// Multiply Axis X * Sens(5)*Smoothing(2)
        //// The same with Axes Y
        //// X & Y axes =[-1;1]

        //smoothV.x =Mathf.Lerp(smoothV.x, md.x, 1f / smoothing) ;
        //smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing) ;
        //mouseLook += smoothV;

        ////if (mouseLook.y >= (-85f) && mouseLook.y <= 85f)
        ////{
        ////    transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        ////    charetcter.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, charetcter.transform.up);
        ////}
        //transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        ////transform.localRotation = Quaternion.AngleAxis(mouseLook.x, charetcter.transform.up);
        #endregion

        if(Input.GetAxis("Fire1")>0)
        {
            rotXY += new Vector2((Input.GetAxis("Mouse X") * sensitivity)%360, (Input.GetAxis("Mouse Y") * sensitivity)%360);

            rotX = rotXY.x;
            rotY = rotXY.y;

            transform.localRotation = originalRot * Quaternion.AngleAxis(rotX, Vector3.up) * Quaternion.AngleAxis(rotY, Vector3.left);
        }
        

    }
}
                                                                                            