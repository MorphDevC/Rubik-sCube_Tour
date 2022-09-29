using System.Collections.Generic;
using UnityEngine;

public class VolumeObjectData
{
    public VolumeObjectData():this(Vector3.zero) {}
    public VolumeObjectData(Vector3 position):this(position,Vector3.zero) {}

    public VolumeObjectData(Vector3 position, Vector3 rotation)
    {
        GetPosition = position;
        GetRotation = rotation;
    }

    public Vector3 GetPosition { get; private set; }

    public Vector3 GetRotation { get; private set; }
}