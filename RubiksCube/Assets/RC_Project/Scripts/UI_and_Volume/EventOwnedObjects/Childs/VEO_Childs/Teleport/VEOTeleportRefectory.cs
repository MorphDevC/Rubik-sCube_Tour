using System.Collections.Generic;

public class VEOTeleportRefectory:VEOTeleport
{
    public override void Awake()
    {
        base.Awake();
        _panoramaIdToInteraction = new List<byte>() { 5,25,36};    
    }
    public override void SetActiveOwnedObjectOnPanoramaSet(BelongableTag targetTag, bool isActive, byte targetPlane)
    {
        if(!_panoramaIdToInteraction.Contains(targetPlane))
            return;
        base.SetActiveOwnedObjectOnPanoramaSet(targetTag, isActive, targetPlane);
        
    }
}
