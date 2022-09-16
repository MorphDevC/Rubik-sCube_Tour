using System.Collections.Generic;

public class VEOPannel : VolumeEventOwnedObject
{
    private List<byte> _panoramaIdToInteraction = new List<byte>()
    {
        4,9,22,29,30,39,47
    }; // Add 37
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
