using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class ChillPlanesAction : MonoBehaviour
{
    [FormerlySerializedAs("cubeChangingSkyBox")] public PanoramaBehaviour panoramaBehaviour;
    
    private byte numberChillPlane;
    private byte showChillCanvasItem;
    private Renderer _enterMat;
    private bool _firstDindPlane = false;
    private List< GameObject> _smallChillPlanes;
    private GameObject[] _smallChillPlanesArray;
    
    public byte NumberChillPlane
    {
        get
        {
            return this.numberChillPlane;
        }
        set
        {
            this.numberChillPlane = value;
        }
    }
    
    
    private void Start()
    {
        _enterMat = GetComponent<Renderer>();
        StartCoroutine(Delay(0.2f));
    }
    private IEnumerator Delay(float time)
    {
        yield return new WaitForSeconds(time);
        _enterMat.material.DisableKeyword("_EMISSION");
    }
    private void OnMouseEnter()
    {
        _enterMat.material.EnableKeyword("_EMISSION");
        switch (gameObject.name)
        {
           // if = for Chillouts
           // else = ClassRooms
           //
           //
        
            case "ChillNavPlane":
                showChillCanvasItem = 41;
                break;
            case "ChillPlane1":
                if (PanoramaBehaviour.InChiillPannel)
                    showChillCanvasItem = 9;
                else
                    showChillCanvasItem = 4;
                break;
            case "ChillPlane2":
                if (PanoramaBehaviour.InChiillPannel)
                    showChillCanvasItem = 30;
                else
                    showChillCanvasItem = 22;
                break;
            case "ChillPlane3":
                if (PanoramaBehaviour.InChiillPannel)
                    showChillCanvasItem = 47;
                else
                    showChillCanvasItem = 29; 
                break;
            case "ChillPlane4":
                if (PanoramaBehaviour.InChiillPannel)
                    showChillCanvasItem = 37;
                //else
                    //showChillCanvasItem = 39;// peregovorniy
                break;
        }
        panoramaBehaviour.ShowDestinationPlane(showChillCanvasItem);
    
    }
    private void OnMouseExit()
    {
        _enterMat.material.DisableKeyword("_EMISSION");
        panoramaBehaviour.UI_ImageBackground.SetActive(false);
    }
    
    private void OnMouseDown()
    {
        _enterMat.material.DisableKeyword("_EMISSION");
        switch (gameObject.name)
        {
            case "ChillNavPlane":
                NumberChillPlane = 41;
                break;
            case "ChillPlane1":
                if (PanoramaBehaviour.InChiillPannel)
                    NumberChillPlane = 9;
                else
                    NumberChillPlane = 4;
                break;
            case "ChillPlane2":
                if (PanoramaBehaviour.InChiillPannel)
                    NumberChillPlane = 30;
                else
                    NumberChillPlane = 22;
                break;
            case "ChillPlane3":
                if (PanoramaBehaviour.InChiillPannel)
                    NumberChillPlane = 47;
                else
                    NumberChillPlane = 29;
                break;
            case "ChillPlane4":
                if (PanoramaBehaviour.InChiillPannel)
                    NumberChillPlane = 37;
                else
                    NumberChillPlane = 39;
                break;
            
        }
        panoramaBehaviour.ChangePanorama(NumberChillPlane);
        
    }

}
