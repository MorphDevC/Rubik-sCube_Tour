using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChillPlanesAction : MonoBehaviour
{
    public Material material;

    public CubeChangingSkyBox cubeChangingSkyBox;

    private byte numberChillPlane;
    private byte showChillCanvasItem;
    


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

    private void Awake()
    {
        StartCoroutine(Delay(1));
    }
    private IEnumerator Delay(float time)
    {
        yield return new WaitForSeconds(time);
        material.DisableKeyword("_EMISSION");
    }

    private void OnMouseEnter()
    {
        material.EnableKeyword("_EMISSION");
        switch(gameObject.name)
        {
            #region
            //case "ChillNavPlane":
            //    showChillCanvasItem = 41;
            //    break;
            //case "ChillPlane1":
            //    showChillCanvasItem = 9;
            //    break;
            //case "ChillPlane2":
            //    showChillCanvasItem = 30;
            //    break;
            //case "ChillPlane3":
            //    showChillCanvasItem = 47;
            //    break;
            //case "ChillPlane4":
            //    showChillCanvasItem = 37;
            //    break;
            #endregion
            case "ChillNavPlane":
                showChillCanvasItem = 41;
                break;
            case "ChillPlane1":
                if (CubeChangingSkyBox.InChiillPannel)
                    showChillCanvasItem = 9;
                else
                    showChillCanvasItem = 4;
                break;
            case "ChillPlane2":
                if (CubeChangingSkyBox.InChiillPannel)
                    showChillCanvasItem = 30;
                else
                    showChillCanvasItem = 22;
                break;
            case "ChillPlane3":
                if (CubeChangingSkyBox.InChiillPannel)
                    showChillCanvasItem = 47;
                else
                    showChillCanvasItem = 29;
                break;
            case "ChillPlane4":
                if (CubeChangingSkyBox.InChiillPannel)
                    showChillCanvasItem = 37;
                else
                    showChillCanvasItem = 39;
                break;
        }
        cubeChangingSkyBox.ShowDestinationPlane(showChillCanvasItem);

    }
    private void OnMouseExit()
    {
        material.DisableKeyword("_EMISSION");
        //cubeChangingSkyBox.RTU_Canvas.SetActive(false);
    }

    private void OnMouseDown()
    {
        material.DisableKeyword("_EMISSION");
        switch (gameObject.name)
        {
            case "ChillNavPlane":
                NumberChillPlane = 41;
                break;
            case "ChillPlane1":
                if (CubeChangingSkyBox.InChiillPannel)
                    NumberChillPlane = 9;
                else
                    NumberChillPlane = 4;
                break;
            case "ChillPlane2":
                if (CubeChangingSkyBox.InChiillPannel)
                    NumberChillPlane = 30;
                else
                    NumberChillPlane = 22;
                break;
            case "ChillPlane3":
                if (CubeChangingSkyBox.InChiillPannel)
                    NumberChillPlane = 47;
                else
                    NumberChillPlane = 29;
                break;
            case "ChillPlane4":
                if (CubeChangingSkyBox.InChiillPannel)
                    NumberChillPlane = 37;
                else
                    NumberChillPlane = 39;
                break;
            
        }
        cubeChangingSkyBox.ChangeSkyBox(NumberChillPlane);
        
    }

}
