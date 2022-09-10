using System.Collections.Generic;
using UnityEngine;

public class VolumeObjectData
{
    private List<Vector3> _positions;
    private List<Vector3> _rotations;
    
    public VolumeObjectData():this(new List<Vector3>()) {}
    public VolumeObjectData(List<Vector3> positions):this(positions,new List<Vector3>()) {}

    public VolumeObjectData(List<Vector3> positions, List<Vector3> rotations)
    {
        _positions = positions;
        _rotations = rotations;
    }
}