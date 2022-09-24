using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class NavStairsSph : MonoBehaviour
{

    [FormerlySerializedAs("cubeChangingSkyBox")] public PanoramaBehaviour panoramaBehaviour;
    //public GameObject NavUp;
    //public GameObject NavDown;

    private byte numberChillPlane; // on which plane we reference in CubeChange...cs
    private static byte _hallOrStairs;
    // true - use nav Arrows for from 0-4 floors
    // false - use nav Arrows for govermant floor (third)

    private byte showLoungeStairs;
    


    public byte NumberChillPlane { get => this.numberChillPlane; set => this.numberChillPlane = value; }

    public static byte HallOrStair { get => _hallOrStairs; set => _hallOrStairs = value; }


    private void OnMouseEnter()
    {
       switch(HallOrStair)
       {
           case 0:
                showLoungeStairs = 7;
               break;
            case 1:
                if(gameObject.name.Equals("NavUp"))
                {
                    showLoungeStairs = 26;
                }
                if(gameObject.name.Equals("NavDown"))
                {
                    showLoungeStairs = 15;
                }
                break;
            case 2:
                if (gameObject.name.Equals("NavUp"))
                {
                    showLoungeStairs = 34;
                }
                if (gameObject.name.Equals("NavDown"))
                {
                    showLoungeStairs = 7;
                }
                break;
            case 3:
                if (gameObject.name.Equals("NavUp"))
                {
                    showLoungeStairs = 41;
                }
                if (gameObject.name.Equals("NavDown"))
                {
                    showLoungeStairs = 26;
                }
                break;
            case 4:
                if (gameObject.name.Equals("NavUp"))
                {
                    showLoungeStairs = 37;// ?
                }
                if (gameObject.name.Equals("NavDown"))
                {
                    showLoungeStairs = 34;
                }
                break;
            case 5:
                showLoungeStairs = 21;
                break;
            case 6:
                if (gameObject.name.Equals("NavUp"))
                {
                    showLoungeStairs = 3;// ?
                }
                if (gameObject.name.Equals("NavDown"))
                {
                    showLoungeStairs = 13;
                }
                break;
            case 7:
                showLoungeStairs = 21;
                break;
            case 8:
                showLoungeStairs = 41;
                break;
        }
        panoramaBehaviour.ShowDestinationPlane(showLoungeStairs);
    }


    private void OnMouseExit()
    {
        panoramaBehaviour.UI_ImageBackground.SetActive(false);
    }
    private void OnMouseDown()
    {
        switch (HallOrStair)
        {
            case 0:
                if (gameObject.name.Equals("NavUp"))
                {
                    NumberChillPlane = 7;
                    HallOrStair = 1;
                }
                break;
            case 1:
                if (gameObject.name.Equals("NavUp"))
                {
                    NumberChillPlane = 26;
                    HallOrStair = 2;
                }
                if (gameObject.name.Equals("NavDown"))
                {
                    NumberChillPlane = 15;
                    HallOrStair = 0;
                }
                break;
            case 2:
                if (gameObject.name.Equals("NavUp"))
                {
                    NumberChillPlane = 34;
                    HallOrStair = 3;
                }
                if (gameObject.name.Equals("NavDown"))
                {
                    NumberChillPlane = 7;
                    HallOrStair = 1;
                }
                break;
            case 3:
                if (gameObject.name.Equals("NavUp"))
                {
                    NumberChillPlane = 41;
                    HallOrStair = 4;
                }
                if (gameObject.name.Equals("NavDown"))
                {
                    NumberChillPlane = 26;
                    HallOrStair = 2;
                }
                break;
            case 4:
                if (gameObject.name.Equals("NavUp"))
                {
                    NumberChillPlane = 37;
                    HallOrStair = 8;
                }
                if (gameObject.name.Equals("NavDown"))
                {
                    NumberChillPlane = 34;
                    HallOrStair = 3;
                }
                break;
            case 5:
                NumberChillPlane = 21;
                HallOrStair = 6;
                break;
            case 6:
                if (gameObject.name.Equals("NavUp"))
                {
                    NumberChillPlane = 3;
                    HallOrStair = 7;
                }
                if (gameObject.name.Equals("NavDown"))
                {
                    NumberChillPlane = 13;
                    HallOrStair = 5;
                }
                break;
            case 7:
                NumberChillPlane = 21;
                HallOrStair = 6;
                break;
            case 8:
                NumberChillPlane = 41;
                HallOrStair = 4;
                break;

        }
        panoramaBehaviour.ChangePanorama(NumberChillPlane);
    }
}
