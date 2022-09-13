using System;
using System.Collections.Generic;
using UnityEngine;


public class VolumeEventOwnedObject : EventOwnedObject
{
    // public readonly Dictionary<byte, VolumeObjectData> Position = new Dictionary<byte, VolumeObjectData>()
    // {
    //     {3, new List<Vector3>(){new Vector3(22.5f, 36, -37)} },
    //     {4, new List<Vector3>() {new Vector3(127.5f,37,-205)} },
    //     {5, new List<Vector3>(){new Vector3(377, 9, -147)} },
    // };
    public readonly Dictionary<byte, VolumeObjectData> Position = new Dictionary<byte, VolumeObjectData>()
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
        {22, new VolumeObjectData (new List<Vector3>(){},new List<Vector3>(){})},
        {25, new VolumeObjectData (new List<Vector3>(){new Vector3(148, 4, 10)},new List<Vector3>(){new Vector3(-90, 0, 0)})},
        {26, new VolumeObjectData (new List<Vector3>(){new Vector3(86, 43, -76), new Vector3(101, 27, -81)})},
        {29, new VolumeObjectData (new List<Vector3>(){},new List<Vector3>(){})}, 
        {30, new VolumeObjectData (new List<Vector3>(){new Vector3(-2, 25, 69)},new List<Vector3>(){new Vector3(-90, 85, -90)})}, 
        {34, new VolumeObjectData (new List<Vector3>(){new Vector3(88, 44, -59.5f), new Vector3(108, 29, -41)})},
        {36, new VolumeObjectData (new List<Vector3>(){new Vector3(355, -13, 20), new Vector3(148, 2, -11)},new List<Vector3>(){new Vector3(-90,0,0), new Vector3(-90,0,0)})},
        {37, new VolumeObjectData (new List<Vector3>(){new Vector3(102, 20, 53)},new List<Vector3>(){new Vector3(-90, 0, 33)})}, 
        {39, new VolumeObjectData (new List<Vector3>(){},new List<Vector3>(){})},
        {41, new VolumeObjectData (new List<Vector3>(){new Vector3(136, 34, -63), new Vector3(93, 30, -51.8f)})},
        {43, new VolumeObjectData (new List<Vector3>(){new Vector3(110, 0, -84)},new List<Vector3>(){new Vector3(-90, 0, 0)})},
        {47, new VolumeObjectData (new List<Vector3>(){},new List<Vector3>(){})},
    };
    public override void Awake()
    {
        base.Awake();
    }
    
    public override void SetActiveOnPanoramaSetOwnedObject(BelongableTag targetTag, bool isActive, byte targetPlane)
    {
        base.SetActiveOnPanoramaSetOwnedObject(targetTag, isActive, targetPlane);
    }

    public override void SetActiveStatusOwnedObject(BelongableTag targetTag, bool isActive)
    {
        base.SetActiveStatusOwnedObject(targetTag, isActive);
    }
    
    public void SetChildPosition(Transform targetChild, Vector3 position)
    {
        targetChild.localPosition = position;
    }
    public void SetChildRotation(Transform targetChild, Vector3 rotation)
    {
        targetChild.localEulerAngles = rotation;
    }
}