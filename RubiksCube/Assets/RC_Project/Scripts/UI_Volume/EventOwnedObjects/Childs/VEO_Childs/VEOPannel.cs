using System.Collections.Generic;

public class VEOPannel : VolumeEventOwnedObject
{
    private List<byte> _panoramaIdToInteraction = new List<byte>()
    {
        4,9,22,29,30,37,39,47
    };
    public override void SetActiveOnPanoramaSetOwnedObject(BelongableTag targetTag, bool isActive, byte targetPlane)
    {
        if(!_panoramaIdToInteraction.Contains(targetPlane))
            return;
        base.SetActiveOnPanoramaSetOwnedObject(targetTag, isActive, targetPlane);
    }
}
