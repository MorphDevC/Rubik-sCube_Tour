using System;
using System.Collections.Generic;
using UnityEngine;

public class VEOPannel : VolumeEventOwnedObject
{
    public event Action<List<byte>> OnSetPanelFromCube;
    private bool _isPanelSet = false;

    public override void SetActiveOwnedObjectOnPanoramaSet(BelongableTag targetTag, bool isActive, byte targetPlane)
    {
        base.SetActiveOwnedObjectOnPanoramaSet(targetTag, isActive, targetPlane);
        SetPanelTransformInScene(targetPlane);
    }

    protected void InvokeEventOnPanelSet(List<byte> targetPanoramasId)
    {
        OnSetPanelFromCube?.Invoke(targetPanoramasId);
        IsPanelSet = true;
    }

    private void SetPanelTransformInScene(byte targetPlane)
    {
        for (int index = 0; index < VolumeObjectDataTransform[targetPlane].GetPositions.Count; index++)
        {
            transform.localPosition = VolumeObjectDataTransform[targetPlane].GetPositions[index];
            transform.localEulerAngles = VolumeObjectDataTransform[targetPlane].GetRotations[index];
        }
    }

    public bool IsPanelSet
    {
        get => _isPanelSet;
        private set =>_isPanelSet = value;
    }
}
