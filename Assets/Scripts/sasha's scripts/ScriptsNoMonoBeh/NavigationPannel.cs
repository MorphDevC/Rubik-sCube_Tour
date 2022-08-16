using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationPannel
{
    public static void SetNavPannel(GameObject _pannel, Vector3 _position, Vector3 _rotation,bool inChillPannel)
    {
        if (inChillPannel)
        {
            _pannel.SetActive(true);
            _pannel.transform.position = _position;
            _pannel.transform.localEulerAngles = _rotation;
            CubeChangingSkyBox.InChiillPannel = inChillPannel;
        }
        else
        {
            _pannel.SetActive(true);
            _pannel.transform.localPosition = _position;
            _pannel.transform.localEulerAngles = _rotation;
            CubeChangingSkyBox.InChiillPannel = inChillPannel;
        }
    }

    public static void SetNavUpDownSpheresFalse(GameObject NavUp, GameObject NavDown)
    {
        NavUp.SetActive(false);
        NavDown.SetActive(false);
    }

}
