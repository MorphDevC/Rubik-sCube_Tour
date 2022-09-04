using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UIBelongableObjectsManager:MonoBehaviour
{
    [SerializeField] private CubeChangingSkyBox _cubeChangingSkyBoxReference;

    private List<IUIBelongableObject> _belongableObjects;
    private void Awake()
    {
        var k = GetComponentsInParent<UIBelongableObject>().ToList(); 
        _belongableObjects = GetComponentsInChildren<IUIBelongableObject>().ToList();
        RegisterObjectsOnPanoramaStatusChange(_belongableObjects);
    }

    private void RegisterObjectsOnPanoramaStatusChange(List<IUIBelongableObject> belongableObjects)
    {
        belongableObjects.ForEach(obj=>_cubeChangingSkyBoxReference.OnPanoramaSetUI+=obj.SetActiveBelongableObject);
        belongableObjects.ForEach(obj=>_cubeChangingSkyBoxReference.OnPanoramaUnSetUI+=obj.SetActiveBelongableObject);
    }
    
    
}
