using System;
using System.Collections.Generic;
using UnityEngine;


public class VolumeEventOwnedObject : EventOwnedObject
{
    protected Dictionary<byte, List<VolumeObjectData>> VolumeObjectDataTransform = new Dictionary<byte, List<VolumeObjectData>>();

     protected List<byte> _panoramaIdToInteraction;
    public event Action<List<byte>> OnSetObjectFromCube;
    private bool _isObjectSet = false;
    
    
    // TODO: refactor this func cuz can be mistakes in inherits
    protected virtual void SetChildObjectsInScene(byte targetPlane)
    {
        for (int index = 0; index < VolumeObjectDataTransform[targetPlane].Count; index++)
        {
            GameObject child = transform.GetChild(index).gameObject;
            child.SetActive(true);
            SetChildPosition(child.transform, VolumeObjectDataTransform[targetPlane][index].GetPosition);
            SetChildRotation(child.transform, VolumeObjectDataTransform[targetPlane][index].GetRotation);
        }
    }
    
    protected void InvokeEventOnPanelSet(List<byte> targetPanoramasId)
    {
        OnSetObjectFromCube?.Invoke(targetPanoramasId);
        IsObjectSet = true;
    }
    
    private void SetChildPosition(Transform targetChild, Vector3 position)
    {
        targetChild.localPosition = position;
    }
    private void SetChildRotation(Transform targetChild, Vector3 rotation)
    {
        targetChild.localEulerAngles = rotation;
    }
    
    
    public bool IsObjectSet
    {
        get => _isObjectSet;
        private set =>_isObjectSet = value;
    }
}