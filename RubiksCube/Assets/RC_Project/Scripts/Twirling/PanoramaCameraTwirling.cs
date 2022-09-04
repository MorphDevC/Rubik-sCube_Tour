using UnityEngine;

public class PanoramaCameraTwirling : ObjectTwirlingFloat
{
    public CubeChangingSkyBox CubeChangingSkyBoxRef;
    
    // [SerializeField] private OptionsInfo OptionsInfoReference;
    // [SerializeField] private PropertyTag _propertyTag;
    //
    // private IOptionableValue<float> _sensitivity;
    private Vector2 rotXY;
    private Quaternion originalRot;

    public override void Start()
    {
        CubeChangingSkyBoxRef.OnPanoramaSetCamera += SetCameraCameraDefaultRotation;
        CubeChangingSkyBoxRef.OnPanoramaSetCamera += SetCameraCameraRotationOnPanoramaSetCamera;
        CubeChangingSkyBoxRef.OnPanoramaUnSetCamera += SetCameraCameraRotationOnPanoramaUnSetCamera;
        
        base.Start();
        
        this.enabled = false;
    }

    private void SetCameraCameraDefaultRotation()
    {
        rotXY = new Vector2(0, 0);
    }

    private void SetCameraCameraRotationOnPanoramaSetCamera()
    {
        this.enabled = true;
        transform.localEulerAngles = new Vector3(0, 0, 0);
        originalRot = transform.localRotation;
    }

    private void SetCameraCameraRotationOnPanoramaUnSetCamera()
    {
        transform.localEulerAngles = new Vector3(35, 0, 0);
        this.enabled = false;
    }
    
    void Update()
    {
        if(Input.GetAxis("Fire1")>0)
        {
            rotXY += new Vector2((Input.GetAxis("Mouse X") * GetTwirlingValue)%360, (Input.GetAxis("Mouse Y") * GetTwirlingValue)%360);

            transform.localRotation = originalRot * Quaternion.AngleAxis(rotXY.x, Vector3.up) * Quaternion.AngleAxis(rotXY.y, Vector3.left);
        }
    }
}
                                                                                            