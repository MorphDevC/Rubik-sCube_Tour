using System;
using System.Collections.Generic;
using UnityEngine;


public class VolumeEventOwnedObject : EventOwnedObject
{
    public readonly Dictionary<byte, VolumeObjectData> VolumeObjectDataTransform = new Dictionary<byte, VolumeObjectData>()
    {
        {3, new VolumeObjectData(new List<Vector3>(){new Vector3(137f, 36, -37)}) },
        {4, new VolumeObjectData(new List<Vector3>(){new Vector3(127.5f,37,-205)},new List<Vector3>(){new Vector3(-90, 0, -180)}) },
        {5, new VolumeObjectData(new List<Vector3>(){new Vector3(377, 9, -147)},new List<Vector3>(){new Vector3(-90, 0, 0)}) },
        {7, new VolumeObjectData (new List<Vector3>(){new Vector3(101, 43, -88),new Vector3(138, 35, -69)})},
        {9, new VolumeObjectData (new List<Vector3>(){new Vector3(-150, 20, -60)},new List<Vector3>(){new Vector3(-90, 0, -80)})},
        {13, new VolumeObjectData (new List<Vector3>(){new Vector3(135, 34, -87.5f)},new List<Vector3>(){new Vector3(0, 0, 0)})},
        {15, new VolumeObjectData (new List<Vector3>(){new Vector3(93, 39, -36)})},
        {17, new VolumeObjectData (new List<Vector3>(){new Vector3(390, 10, -50)},new List<Vector3>(){new Vector3(-90, 0, 0)})},
        {21, new VolumeObjectData (new List<Vector3>(){new Vector3(138, 36, -34), new Vector3(86, 36, -93)},new List<Vector3>(){new Vector3(0, 0, 0), new Vector3(0, 0, 0)})}, 
        {22, new VolumeObjectData (new List<Vector3>(){new Vector3(143,7,46)},new List<Vector3>(){new Vector3(-90,0,16)})},
        {25, new VolumeObjectData (new List<Vector3>(){new Vector3(148, 4, 10)},new List<Vector3>(){new Vector3(-90, 0, 0)})},
        {26, new VolumeObjectData (new List<Vector3>(){new Vector3(86, 43, -76), new Vector3(101, 27, -81)})},
        {29, new VolumeObjectData (new List<Vector3>(){new Vector3(161,35,-250)},new List<Vector3>(){new Vector3(-90,0,-180)})}, 
        {30, new VolumeObjectData (new List<Vector3>(){new Vector3(100,10,70)},new List<Vector3>(){new Vector3(-90, 0, -5)})}, 
        {34, new VolumeObjectData (new List<Vector3>(){new Vector3(88, 44, -59.5f), new Vector3(108, 29, -41)})},
        {36, new VolumeObjectData (new List<Vector3>(){new Vector3(355, -13, 20), new Vector3(148, 2, -11)},new List<Vector3>(){new Vector3(-90,0,0), new Vector3(-90,0,0)})},
        {37, new VolumeObjectData (new List<Vector3>(){new Vector3(204,6,53)},new List<Vector3>(){new Vector3(-90, 0, 33)})}, 
        {39, new VolumeObjectData (new List<Vector3>(){new Vector3(-33,22,-22)},new List<Vector3>(){ new Vector3(-90, 0, -70)})},
        {41, new VolumeObjectData (new List<Vector3>(){new Vector3(136, 34, -63), new Vector3(93, 30, -51.8f)})},
        {43, new VolumeObjectData (new List<Vector3>(){new Vector3(110, 0, -84)},new List<Vector3>(){new Vector3(-90, 0, 0)})},
        {47, new VolumeObjectData (new List<Vector3>(){new Vector3(-3,21,-144)},new List<Vector3>(){ new Vector3(-90, 0, -127)})},
    };
    protected List<byte> _panoramaIdToInteraction;
    public event Action<List<byte>> OnSetObjectFromCube;
    private bool _isObjectSet = false;
    
    protected virtual void SetChildObjectsInScene(byte targetPlane)
    {
        for (int index = 0; index < VolumeObjectDataTransform[targetPlane].GetPositions.Count; index++)
        {
            GameObject child = transform.GetChild(index).gameObject;
            child.SetActive(true);
            SetChildPosition(child.transform, VolumeObjectDataTransform[targetPlane].GetPositions[index]);
            SetChildRotation(child.transform, VolumeObjectDataTransform[targetPlane].GetRotations[index]);
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