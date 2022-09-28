using System;
using System.Collections.Generic;
using UnityEngine;

public class VEOPannel : VolumeEventOwnedObject
{
    public override void SetActiveOwnedObjectOnPanoramaSet(BelongableTag targetTag, bool isActive, byte targetPlane)
    {
        base.SetActiveOwnedObjectOnPanoramaSet(targetTag, isActive, targetPlane);
        SetPanelTransformInScene(targetPlane);
        if(!IsObjectSet)
            InvokeEventOnPanelSet(_panoramaIdToInteraction);
    }

    private void SetPanelTransformInScene(byte targetPlane)
    {
        for (int index = 0; index < VolumeObjectDataTransform[targetPlane].GetPositions.Count; index++)
        {
            transform.localPosition = VolumeObjectDataTransform[targetPlane].GetPositions[index];
            transform.localEulerAngles = VolumeObjectDataTransform[targetPlane].GetRotations[index];
        }
    }
}
