using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationSphere
{
    
    

    public static void SetNavUpDownSpheres
    (
        GameObject exactlySetTrue_GameObj,
        GameObject mightSetTrue_GameObj,
        Vector3 exactlyPositionGameObj,
        byte HallOrStairs
    )
    // HallOrStairs = n (in reference)
    {
        
         exactlySetTrue_GameObj.SetActive(true); // NavUp
         mightSetTrue_GameObj.SetActive(false);
         exactlySetTrue_GameObj.transform.position = exactlyPositionGameObj;
         NavStairsSph.HallOrStair = HallOrStairs;
        //L= Load StreamingAssets SkyBox
    }

    public static void SetNavUpDownSpheres
    (
        GameObject exactlySetTrue_GameObj, 
        GameObject mightSetTrue_GameObj, 
        Vector3 exactlyPositionGameObj,
        Vector3 mightPositionGameObj,
        byte HallOrStairs
    )
    // HallOrStairs = n (in reference)
    {
         exactlySetTrue_GameObj.SetActive(true);
         mightSetTrue_GameObj.SetActive(true);
         exactlySetTrue_GameObj.transform.position = exactlyPositionGameObj;
         mightSetTrue_GameObj.transform.position = mightPositionGameObj;
         NavStairsSph.HallOrStair = HallOrStairs;
        //L= Load StreamingAssets SkyBox
    }


 




    public static void PannelNavigation(GameObject _pannel, Vector3 _position, Vector3 _rotation)
    {
        _pannel.SetActive(true);
        _pannel.transform.position = _position;
        _pannel.transform.localEulerAngles = _rotation;
    }
    public static void SetFalse(GameObject _navUp, GameObject _navDown)
    {
        _navUp.SetActive(false);
        _navDown.SetActive(false);
        return;
    }
}
