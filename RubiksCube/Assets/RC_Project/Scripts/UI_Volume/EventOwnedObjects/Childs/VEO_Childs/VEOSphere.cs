using System.Collections.Generic;
using UnityEngine;

public class VEOSphere: VolumeEventOwnedObject
{
    private List<byte> _panoramaIdToInteraction = new List<byte>()
    {
        3,7,13,15,21,26,34,41
    };
    public override void SetActiveOnPanoramaSetOwnedObject(BelongableTag targetTag, bool isActive, byte targetPlane)
    {
        if(!_panoramaIdToInteraction.Contains(targetPlane))
            return;
        base.SetActiveOnPanoramaSetOwnedObject(targetTag, isActive, targetPlane);
        for (int index = 0; index < Position[targetPlane].GetPositions.Count; index++)
        {
            GameObject child = transform.GetChild(index).gameObject;
            child.SetActive(true);
            SetChildPosition(child.transform, Position[targetPlane].GetPositions[index]);
            SetChildRotation(child.transform, Position[targetPlane].GetRotations[index]);
        }
    }
}
