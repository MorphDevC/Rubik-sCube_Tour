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
        {3, new VolumeObjectData(new List<Vector3>(){new Vector3(22.5f, 36, -37)}) },
        {4, new VolumeObjectData(new List<Vector3>(){new Vector3(127.5f,37,-205)},new List<Vector3>(){new Vector3(-90, 0, -180)}) },
        {5, new VolumeObjectData(new List<Vector3>(){new Vector3(377, 9, -147)}) },
        {7, new VolumeObjectData (new List<Vector3>(){new Vector3(-14, 43, -88),new Vector3(23, 35, -69)})},
        {9, new VolumeObjectData (new List<Vector3>(){new Vector3(-150, 20, -60)},new List<Vector3>(){new Vector3(-90, 0, -80)})},
        {13, new VolumeObjectData (new List<Vector3>(){new Vector3(20, 34, -87.5f)})},
        {15, new VolumeObjectData (new List<Vector3>(){},new List<Vector3>(){})},
        {17, new VolumeObjectData (new List<Vector3>(){},new List<Vector3>(){})},
        {21, new VolumeObjectData (new List<Vector3>(){},new List<Vector3>(){})}, 
        {22, new VolumeObjectData (new List<Vector3>(){},new List<Vector3>(){})},
        {25, new VolumeObjectData (new List<Vector3>(){},new List<Vector3>(){})},
        {26, new VolumeObjectData (new List<Vector3>(){},new List<Vector3>(){})},
        {29, new VolumeObjectData (new List<Vector3>(){},new List<Vector3>(){})}, 
        {30, new VolumeObjectData (new List<Vector3>(){new Vector3(-2, 25, 69)},new List<Vector3>(){new Vector3(-90, 85, -90)})}, 
        {34, new VolumeObjectData (new List<Vector3>(){},new List<Vector3>(){})},
        {36, new VolumeObjectData (new List<Vector3>(){},new List<Vector3>(){})},
        {37, new VolumeObjectData (new List<Vector3>(){new Vector3(102, 20, 53)},new List<Vector3>(){new Vector3(-90, 0, 33)})}, 
        {39, new VolumeObjectData (new List<Vector3>(){},new List<Vector3>(){})},
        {41, new VolumeObjectData (new List<Vector3>(){},new List<Vector3>(){})},
        {43, new VolumeObjectData (new List<Vector3>(){},new List<Vector3>(){})},
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
}