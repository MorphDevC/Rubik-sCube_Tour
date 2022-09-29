using System.Collections.Generic;
using UnityEngine;

public class VolumeObjectData
{
    public VolumeObjectData():this(Vector3.zero) {}
    public VolumeObjectData(Vector3 position):this(position,Vector3.zero) {}

    public VolumeObjectData(Vector3 position, Vector3 rotation, byte selfPanoramaID = default)
    {
        GetPosition = position;
        GetRotation = rotation;
        SelfPanoramaID = selfPanoramaID;
    }

    public Vector3 GetPosition { get; private set; }

    public Vector3 GetRotation { get; private set; }
    public byte SelfPanoramaID { get; private set; }
}