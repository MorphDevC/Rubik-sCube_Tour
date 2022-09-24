using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;

public class EventOwnedObjectsManager:MonoBehaviour
{
    [FormerlySerializedAs("_cubeChangingSkyBoxReference")] [SerializeField] private PanoramaBehaviour panoramaBehaviourReference;

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
        eventOwnedObjects.ForEach(obj=>panoramaBehaviourReference.OnPanoramaSetOwnedObjects+=obj.SetActiveOwnedObjectOnPanoramaSet);
        eventOwnedObjects.ForEach(obj=>panoramaBehaviourReference.OnPanoramaUnSetOwnedObjects+=obj.SetActiveStatusOwnedObject);
    }
    
    
}
