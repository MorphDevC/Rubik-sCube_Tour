using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class VolumeEventOwnedObject : EventOwnedObject
{
    protected Dictionary<byte, List<VolumeObjectData>> VolumeObjectDataTransform = new Dictionary<byte, List<VolumeObjectData>>();
    protected List<ISceneSetObject> _sceneSetObjects;
    public event Action<List<byte>> OnSetObjectFromCube;
    private bool _isObjectSet = false;

    public override void Awake()
    {
        base.Awake();
        _sceneSetObjects = GetComponentsInChildren<ISceneSetObject>().ToList();
    }

    protected virtual void SetObjectsInScene(byte targetPlane)
    {
        int index2 = 0;
        foreach (var objectData in VolumeObjectDataTransform[targetPlane])
        {
            _sceneSetObjects[index2].SetActiveObject(true);
            _sceneSetObjects[index2].SetChildPosition(objectData.GetPosition);
            _sceneSetObjects[index2].SetChildRotation(objectData.GetRotation);
            index2++;
        }

        for (int i = index2; i < _sceneSetObjects.Count; i++)
        {
            _sceneSetObjects[i].SetActiveObject(false);
        }
    }
    
    protected void InvokeEventOnPanelSet(List<byte> targetPanoramasId)
    {
        OnSetObjectFromCube?.Invoke(targetPanoramasId);
        IsObjectSet = true;
    }
    
    
    public bool IsObjectSet
    {
        get => _isObjectSet;
        private set =>_isObjectSet = value;
    }
}