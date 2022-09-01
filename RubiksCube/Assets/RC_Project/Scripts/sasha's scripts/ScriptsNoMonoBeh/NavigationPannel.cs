using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationPannel
{
    public static void SetNavPannel(GameObject _pannel, Vector3 _position, Vector3 _rotation,bool inChillPannel)
    {
        if (inChillPannel)
        {
            CubeChangingSkyBox.InChiillPannel = inChillPannel;
            _pannel.SetActive(true);
            _pannel.transform.position = _position;
            _pannel.transform.localEulerAngles = _rotation;
            
        }
        else
        {
            CubeChangingSkyBox.InChiillPannel = inChillPannel;// must be upper setActive(True) cuz there is script on GameObject with onEnable and this bool
            _pannel.SetActive(true);
            _pannel.transform.localPosition = _position;
            _pannel.transform.localEulerAngles = _rotation;
            
        }
    }

    public static void SetNavUpDownSpheresFalse(GameObject NavUp, GameObject NavDown)
    {
        NavUp.SetActive(false);
        NavDown.SetActive(false);
    }

}
