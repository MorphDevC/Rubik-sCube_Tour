using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportAction : MonoBehaviour
{
    public Material BlueTeleportMat;
    private static byte _refPos;
    public CubeChangingSkyBox cubeChangingSkyBox;
    private byte _destinationNumber;
    private byte _changeSky;

    public static byte RefPos { get => _refPos; set => _refPos = value; }
    private void Awake()
    {
        BlueTeleportMat.DisableKeyword("_EMISSION");
    }


    private void OnMouseEnter()
    {
        BlueTeleportMat.EnableKeyword("_EMISSION");
        
        switch(RefPos)
        {
            case 1:
                _destinationNumber = 36;
                break;
            case 2:
                if (gameObject.name.Equals("RefecTelLeft"))
                    _destinationNumber = 5;
                else if (gameObject.name.Equals("RefecTelRight"))
                    _destinationNumber = 25;
                break;
            case 3:
                _destinationNumber = 43;
                break;
            case 4:
                _destinationNumber = 17;
                break;
        }
        #region BackupStrings
        //if(RefPos==1)
        //{
        //    _destinationNumber = 36;
        //}
        //else if(RefPos==2)
        //{
        //    if (gameObject.name.Equals("RefecTelLeft"))
        //        _destinationNumber = 5;
        //    else if (gameObject.name.Equals("RefecTelRight"))
        //        _destinationNumber = 25;
        //}
        #endregion
        cubeChangingSkyBox.ShowDestinationPlane(_destinationNumber);
    }

    private void OnMouseExit()
    {
        BlueTeleportMat.DisableKeyword("_EMISSION");
        cubeChangingSkyBox.UI_ImageBackground.SetActive(false);
    }
    // 5  (0) - RefectoryLeft
    // 25 (1) - RefectoryRight
    // 36 (2) - RefectoryMiddle
    private void OnMouseDown()
    {
        #region BackupString
        //switch(RefPos) // заменить на true false
        //{
        //    case 0:
        //        cubeChangingSkyBox.ChangeSkyBox(36);
        //        break;
        //    case 1:
        //        cubeChangingSkyBox.ChangeSkyBox(36);
        //        break;
        //    case 2:
        //        if(gameObject.name.Equals("RefecTelLeft"))
        //            cubeChangingSkyBox.ChangeSkyBox(5);
        //        else if(gameObject.name.Equals("RefecTelRight"))
        //            cubeChangingSkyBox.ChangeSkyBox(25);
        //        break;
        //}
        #endregion
        switch (RefPos)
        {
            case 1:
               _changeSky = 36;
                break;
            case 2:
                if (gameObject.name.Equals("RefecTelLeft"))
                    _changeSky = 5;
                else if (gameObject.name.Equals("RefecTelRight"))
                    _changeSky = 25;
                break;
            case 3:
                _changeSky = 43;
                break;
            case 4:
                _changeSky = 17;
                break;
        }
        cubeChangingSkyBox.ChangeSkyBox(_changeSky);
    }

    


}
