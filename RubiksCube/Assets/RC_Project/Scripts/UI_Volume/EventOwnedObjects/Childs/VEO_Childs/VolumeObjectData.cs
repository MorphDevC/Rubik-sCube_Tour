using System.Collections.Generic;
using UnityEngine;

public class VolumeObjectData
{
    public VolumeObjectData():this(new List<Vector3>()) {}
    public VolumeObjectData(List<Vector3> positions):this(positions,new List<Vector3>(positions.Count)) {}

    public VolumeObjectData(List<Vector3> positions, List<Vector3> rotations)
    {
        GetPositions = positions;
        GetRotations = rotations;
    }

    public List<Vector3> GetPositions { get; private set; }

    public List<Vector3> GetRotations { get; private set; }
}