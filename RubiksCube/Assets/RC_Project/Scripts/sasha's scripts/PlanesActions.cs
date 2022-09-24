using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;


public class PlanesActions : MonoBehaviour
{
    //public CubeChangingSkyBox cubeChangingSkyBox;
    //private static bool _doNotUseSomeStringsInCubeChangeSky=false;
    //public byte NumberPlane {get => this.numberPlane; set => this.numberPlane = value;}
    //public static bool DoNotUseSomeStringsInCubeChangeSky { get => _doNotUseSomeStringsInCubeChangeSky; set => _doNotUseSomeStringsInCubeChangeSky = value; }
    public byte PlaneNumber { get; private set; }
    public Renderer InteractionMaterial { get; private set; }
    public event Action<byte> OnMouseInteractionShowDestination;
    
    private bool _mouseOnPlane = false;
    private void Awake()
    {
        StartCoroutine(Delay(0.2f));
    }

    private void Start()
    {
        InteractionMaterial = GetComponent<Renderer>();
    }

   

    private void OnMouseEnter()
    {
        _mouseOnPlane = true;
        InteractionMaterial.material.EnableKeyword("_EMISSION");
        PlaneNumber = Convert.ToByte(gameObject.name.Substring(5));
        //cubeChangingSkyBox.ShowDestinationPlane(NumberPlane);
        // each plane is named "Plane№". Substring Deletes "Plane" and leaves only №.
    }

    private void OnMouseExit()
    {
        _mouseOnPlane = false;
        InteractionMaterial.material.DisableKeyword("_EMISSION");
       // cubeChangingSkyBox.UI_ImageBackground.SetActive(false);
    }

    private void OnMouseUp()
    {
        if (_mouseOnPlane)
        {
            //DoNotUseSomeStringsInCubeChangeSky = false;
            InteractionMaterial.material.DisableKeyword("_EMISSION");
            PlaneNumber = Convert.ToByte(gameObject.name.Substring(5)); //SubString(5) = Delete (P l a n e)
            //cubeChangingSkyBox.ChangeSkyBox(NumberPlane);
        }
    }
    

    private IEnumerator Delay(float time)
    {
        yield return new WaitForSeconds(time);
        InteractionMaterial.material.DisableKeyword("_EMISSION");
    }
    
}
