using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EventOwnedObjectsManager:MonoBehaviour
{
    [SerializeField] private CubeChangingSkyBox _cubeChangingSkyBoxReference;

    private List<IEventOwnedObject> _eventOwnedObjects;
    private void Awake()
    {
        _eventOwnedObjects = GetComponentsInChildren<IEventOwnedObject>().ToList();
        RegisterObjectsOnPanoramaStatusChange(_eventOwnedObjects);
    }

    private void Start()
    {
        _eventOwnedObjects.ForEach(obj=>obj.SetActiveStatusOwnedObject(BelongableTag.Cube,true));
    }

    private void RegisterObjectsOnPanoramaStatusChange(List<IEventOwnedObject> eventOwnedObjects)
    {
        eventOwnedObjects.ForEach(obj=>_cubeChangingSkyBoxReference.OnPanoramaSetOwnedObjects+=obj.SetActiveOwnedObjectOnPanoramaSet);
        eventOwnedObjects.ForEach(obj=>_cubeChangingSkyBoxReference.OnPanoramaUnSetOwnedObjects+=obj.SetActiveStatusOwnedObject);
    }
    
    
}
