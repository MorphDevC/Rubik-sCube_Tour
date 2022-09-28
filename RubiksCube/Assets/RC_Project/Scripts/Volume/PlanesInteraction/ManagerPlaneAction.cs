using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ManagerPlaneAction : MonoBehaviour
{
    protected List<IPlaneAction> _planes = new List<IPlaneAction>();
    protected List<VolumeEventOwnedObject> _volumeEventOwnedObjectsRef;

    protected virtual void Awake()
    {
        _planes = GetComponentsInChildren<IPlaneAction>().ToList();
        
        //TODO: maybe refactor this
        _volumeEventOwnedObjectsRef = GetComponents<VolumeEventOwnedObject>().ToList();
        _volumeEventOwnedObjectsRef.ForEach(reference=>reference.OnSetObjectFromCube+=SetPlanesIdOnPanelSet);
    }

    public void RegisterFuncOnPlaneEnter(Action<byte> targetFunction)
    {
        _planes.ForEach(plane=>plane.OnMousePlaneEnter+=targetFunction);
    }
    public void RegisterFuncOnPlaneExit(Action targetFunction)
    {
        _planes.ForEach(plane=>plane.OnMousePlaneExit+=targetFunction);
    }
    public void RegisterFuncOnPlaneSelected(Action<byte> targetFunction)
    {
        _planes.ForEach(plane=>plane.OnMousePlaneSelected+=targetFunction);
    }
    
    protected void SetPlanesIdOnPanelSet(List<byte> targetIds)
    {
        for (int i = 0; i < targetIds.Count; i++)
        {
            _planes[i].SetPlaneNumber(targetIds[i]);
        }
    }
    
}
