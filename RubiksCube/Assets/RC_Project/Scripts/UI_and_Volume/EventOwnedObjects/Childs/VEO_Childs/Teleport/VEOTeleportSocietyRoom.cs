using System.Collections.Generic;

public class VEOTeleportSocietyRoom:VEOTeleport
{
    public override void Awake()
    {
        base.Awake();
        _panoramaIdToInteraction = new List<byte>() { 17,43 };    
    }
    
    public override void SetActiveOwnedObjectOnPanoramaSet(BelongableTag targetTag, bool isActive, byte targetPlane)
    {
        if(!_panoramaIdToInteraction.Contains(targetPlane))
            return;
        base.SetActiveOwnedObjectOnPanoramaSet(targetTag, isActive, targetPlane);
    }
}
