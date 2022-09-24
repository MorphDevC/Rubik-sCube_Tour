using System.Collections.Generic;

public class VEOSphere: VolumeEventOwnedObject
{
    private List<byte> _panoramaIdToInteraction = new List<byte>()
    {
        3,7,13,15,21,26,34,41
    };//add 37
    public override void SetActiveOwnedObjectOnPanoramaSet(BelongableTag targetTag, bool isActive, byte targetPlane)
    {
        if(!_panoramaIdToInteraction.Contains(targetPlane))
            return;
        base.SetActiveOwnedObjectOnPanoramaSet(targetTag, isActive, targetPlane);
        SetChildObjectsInScene(targetPlane);
    }

    protected override void SetChildObjectsInScene(byte targetPlane)
    {
        base.SetChildObjectsInScene(targetPlane);
    }
}
