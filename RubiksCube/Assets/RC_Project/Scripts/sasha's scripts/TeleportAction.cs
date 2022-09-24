using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportAction : MonoBehaviour
{
    
    private static byte _refPos;
    public PanoramaBehaviour panoramaBehaviour;
    private byte _destinationNumber;
    private byte _changeSky;
    private Renderer _enterMat;

    public static byte RefPos { get => _refPos; set => _refPos = value; }
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

        switch (RefPos)
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
        panoramaBehaviour.ShowDestinationPlane(_destinationNumber);
    }

    private void OnMouseExit()
    {
        _enterMat.material.DisableKeyword("_EMISSION");
        panoramaBehaviour.UI_ImageBackground.SetActive(false);
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
        _enterMat.material.DisableKeyword("_EMISSION");
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
        panoramaBehaviour.ChangePanorama(_changeSky);
    }

    


}
