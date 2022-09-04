using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BelongableObjectsManager:MonoBehaviour
{
    [SerializeField] private CubeChangingSkyBox _cubeChangingSkyBoxReference;

    private List<IBelongableObject> _belongableObjects;
    private void Awake()
    {
        _belongableObjects = GetComponentsInChildren<IBelongableObject>().ToList();
        RegisterObjectsOnPanoramaStatusChange(_belongableObjects);
    }

    private void Start()
    {
        _belongableObjects.ForEach(obj=>obj.SetActiveBelongableObject(BelongableTag.Cube,true));
    }

    private void RegisterObjectsOnPanoramaStatusChange(List<IBelongableObject> belongableObjects)
    {
        belongableObjects.ForEach(obj=>_cubeChangingSkyBoxReference.OnPanoramaSetUI+=obj.SetActiveBelongableObject);
        belongableObjects.ForEach(obj=>_cubeChangingSkyBoxReference.OnPanoramaUnSetUI+=obj.SetActiveBelongableObject);
    }
    
    
}
