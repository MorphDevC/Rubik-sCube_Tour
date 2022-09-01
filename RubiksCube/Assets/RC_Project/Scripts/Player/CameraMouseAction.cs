using UnityEngine;

public class CameraMouseAction : MonoBehaviour
{
    public CubeChangingSkyBox CubeChangingSkyBoxRef;
    
   
    private float sensitivity = 2.0f;
    private Vector2 rotXY;
    private Quaternion originalRot;

    void Start()
    {
        CubeChangingSkyBoxRef.OnPanoramaSet += SetCameraDefaultRotation;
        CubeChangingSkyBoxRef.OnPanoramaSet += SetCameraRotationOnPanoramaSet;
        CubeChangingSkyBoxRef.OnPanoramaUnSet += SetCameraRotationOnPanoramaUnSet;
        
        this.enabled = false;
    }

    public void SetNewSensivity(string sens)
    {
        sensitivity = float.Parse(sens, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
    }

    private void SetCameraDefaultRotation()
    {
        rotXY = new Vector2(0, 0);
    }

    private void SetCameraRotationOnPanoramaSet()
    {
        this.enabled = true;
        transform.localEulerAngles = new Vector3(0, 0, 0);
        originalRot = transform.localRotation;
    }

    private void SetCameraRotationOnPanoramaUnSet()
    {
        transform.localEulerAngles = new Vector3(35, 0, 0);
        this.enabled = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Fire1")>0)
        {
            rotXY += new Vector2((Input.GetAxis("Mouse X") * sensitivity)%360, (Input.GetAxis("Mouse Y") * sensitivity)%360);

            transform.localRotation = originalRot * Quaternion.AngleAxis(rotXY.x, Vector3.up) * Quaternion.AngleAxis(rotXY.y, Vector3.left);
        }
    }
}
                                                                                            