using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetChildsInChillPannels : MonoBehaviour
{
    private GameObject _parentChillPlane; // On which GameObject put script 
    private bool _getChillPlane = false; // not every time get positions in list
    private List<Vector3> _localPositionsSmallPlanes = new List<Vector3>(); // getting local positions of planes
    private Vector3 _localRotationsFirstPlane = new Vector3(); // for 1st plane which only 1 rotates in this script

    private Vector3[] _positionPlanesInRooms = new Vector3[]
    {
        new Vector3(-3.25f, 0.02f, -0.18f), //0
        new Vector3(1.56f,0.02f,-0.18f),    //1
        new Vector3(0,0,0),                 //2
        new Vector3(1.56f, 0.02f, -3.35f),  //3
    
    };



    private void OnEnable()
    {
        
        if(!_getChillPlane)
        {
            _parentChillPlane = gameObject;

            for (int i = 0; i < 5; i++)
            {
                _localPositionsSmallPlanes.Add(_parentChillPlane.transform.GetChild(i).transform.localPosition); //saving positions
            }
            
            _localRotationsFirstPlane=_parentChillPlane.transform.GetChild(1).transform.localEulerAngles; // get 1 cuz only 1 has to rotate
           
            _getChillPlane = true;
        }

        if (PanoramaBehaviour.InChiillPannel)
        {
            _parentChillPlane.transform.GetChild(4).gameObject.SetActive(true);
            _parentChillPlane.transform.GetChild(0).gameObject.transform.localPosition = _localPositionsSmallPlanes[0];
            _parentChillPlane.transform.GetChild(1).gameObject.transform.localPosition =_localPositionsSmallPlanes[1];
            _parentChillPlane.transform.GetChild(3).gameObject.transform.localPosition = _localPositionsSmallPlanes[3];

            _parentChillPlane.transform.GetChild(1).gameObject.transform.localEulerAngles = _localRotationsFirstPlane;
        }
        else
        {
            _parentChillPlane.transform.GetChild(4).gameObject.SetActive(false);
            _parentChillPlane.transform.GetChild(0).gameObject.transform.localPosition = _positionPlanesInRooms[0];
            _parentChillPlane.transform.GetChild(1).gameObject.transform.localPosition= _positionPlanesInRooms[1];
            _parentChillPlane.transform.GetChild(3).gameObject.transform.localPosition = _positionPlanesInRooms[3];


            _parentChillPlane.transform.GetChild(1).gameObject.transform.localEulerAngles = new Vector3(0, 90, 0);

        }

    }
}
