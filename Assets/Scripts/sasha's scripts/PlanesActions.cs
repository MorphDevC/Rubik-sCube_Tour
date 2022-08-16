using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;


public class PlanesActions : MonoBehaviour
{
    

    public CubeChangingSkyBox cubeChangingSkyBox;


    private static bool _doNotUseSomeStringsInCubeChangeSky=false;

    private byte numberPlane;

    public byte NumberPlane {get => this.numberPlane; set => this.numberPlane = value;}
    public static bool DoNotUseSomeStringsInCubeChangeSky { get => _doNotUseSomeStringsInCubeChangeSky; set => _doNotUseSomeStringsInCubeChangeSky = value; }
    private Renderer _enterMat;
    private void Awake()
    {
        StartCoroutine(Delay(0.2f));
    }

    private void Start()
    {
       
        _enterMat = GetComponent<Renderer>();
    }

    private void OnMouseEnter()
    {
        _enterMat.material.EnableKeyword("_EMISSION");
        NumberPlane = Convert.ToByte(gameObject.name.Substring(5));
        cubeChangingSkyBox.ShowDestinationPlane(NumberPlane);
        // each plane is named "Plane№". Substring Deletes "Plane" and leaves only №.
    }

    private void OnMouseExit()
    {
        _enterMat.material.DisableKeyword("_EMISSION");
        cubeChangingSkyBox.UI_ImageBackground.SetActive(false);
    }

    private void OnMouseDown()
    {
        DoNotUseSomeStringsInCubeChangeSky = false;
        _enterMat.material.DisableKeyword("_EMISSION");
        NumberPlane = Convert.ToByte(gameObject.name.Substring(5)); //SubString(5) = Delete (P l a n e)
        cubeChangingSkyBox.ChangeSkyBox(NumberPlane);
    }
    

    private IEnumerator Delay(float time)
    {
        yield return new WaitForSeconds(time);
        _enterMat.material.DisableKeyword("_EMISSION");
    }
}
