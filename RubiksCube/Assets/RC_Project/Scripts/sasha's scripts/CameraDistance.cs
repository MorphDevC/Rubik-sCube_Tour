using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDistance : MonoBehaviour
{
    private GameObject _mainCam;
    
    // Start is called before the first frame update
    void Start()
    {
        _mainCam = GameObject.FindWithTag("MainCamera");
    }

    public void Distance(float distance)
    {
        _mainCam.transform.localPosition = new Vector3(_mainCam.transform.localPosition.x-distance, _mainCam.transform.localPosition.y+distance, _mainCam.transform.localPosition.z+ distance);
    }

}
