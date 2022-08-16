using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataHolderScenes : MonoBehaviour
{
    private static byte _idChangeSkyBox;
    private static byte _idShowPlaneDestinition;

    public static byte Id { get => _idChangeSkyBox; set => _idChangeSkyBox = value; }
    public static byte IdShowPlaneDestinition { get => _idShowPlaneDestinition; set => _idShowPlaneDestinition = value; }
    //public ShowAcademicDiscCanvas AcademicCanvas;

    public void SetTrueCanvas()
    {
        //AcademicCanvas.AcademicDisc_Canvas.SetActive(true);
    }

    public void SetFalseCanvas()
    {
        //AcademicCanvas.AcademicDisc_Canvas.SetActive(false);
    }
}
