using System.Collections.Generic;

public class VEOSphere: VolumeEventOwnedObject
{
    private List<byte> _panoramaIdToInteraction = new List<byte>()
    {
        3,7,13,14,21,26,34,41
    };
    public override void SetActiveOnPanoramaSetOwnedObject(BelongableTag targetTag, bool isActive, byte targetPlane)
    {
        if(!_panoramaIdToInteraction.Contains(targetPlane))
            return;
        base.SetActiveOnPanoramaSetOwnedObject(targetTag, isActive, targetPlane);
    }
}
