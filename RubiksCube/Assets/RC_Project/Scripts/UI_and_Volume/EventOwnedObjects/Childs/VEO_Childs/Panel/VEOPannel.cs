using System;
using System.Collections.Generic;
using UnityEngine;

public class VEOPannel : VolumeEventOwnedObject
{
    protected List<byte> _panoramaIdToInteraction;
    public override void Awake()
    {
        base.Awake();
        VolumeObjectDataTransform = new Dictionary<byte, List<VolumeObjectData>>()
        {
            {4, new List<VolumeObjectData>() {
                new VolumeObjectData(new Vector3(127.5f,37,-205),new Vector3(-90, 0, -180))
            }},

            {9, new List<VolumeObjectData> {
                new VolumeObjectData(new Vector3(-150, 20, -60),new Vector3(-90, 0, -80))
            }},

            {22, new List<VolumeObjectData> {
                new VolumeObjectData(new Vector3(143,7,46),new Vector3(-90,0,16))
            }},
        
            {29, new List<VolumeObjectData> {
                new VolumeObjectData(new Vector3(161,35,-250),new Vector3(-90,0,-180))
            }}, 
        
            {30, new List<VolumeObjectData> {
                new VolumeObjectData(new Vector3(100,10,70),new Vector3(-90, 0, -5))
            }},

            {37, new List<VolumeObjectData> {
                new VolumeObjectData(new Vector3(204,6,53),new Vector3(-90, 0, 33))
            }}, 
        
            {39, new List<VolumeObjectData> {
                new VolumeObjectData(new Vector3(-33,22,-22),new Vector3(-90, 0, -70))
            }},
        
            {47, new List<VolumeObjectData> {
                new VolumeObjectData(new Vector3(-3,21,-144),new Vector3(-90, 0, -127))
            }},
        };
    }

    public override void SetActiveOwnedObjectOnPanoramaSet(BelongableTag targetTag, bool isActive, byte targetPlane)
    {
        base.SetActiveOwnedObjectOnPanoramaSet(targetTag, isActive, targetPlane);
        SetPanelTransformInScene(targetPlane,0);
        if(!IsObjectSet)
            InvokeEventOnPanelSet(_panoramaIdToInteraction);
    }

    private void SetPanelTransformInScene(byte targetPlane, int targetObjectDataIndex)
    {
        if (VolumeObjectDataTransform[targetPlane].Count == 0) return;
        transform.localPosition = VolumeObjectDataTransform[targetPlane][targetObjectDataIndex].GetPosition;
        transform.localEulerAngles = VolumeObjectDataTransform[targetPlane][targetObjectDataIndex].GetRotation;
    }
}
