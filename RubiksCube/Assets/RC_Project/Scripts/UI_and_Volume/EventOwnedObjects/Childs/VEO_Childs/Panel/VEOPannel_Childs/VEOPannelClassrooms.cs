using System.Collections.Generic;

public class VEOPannelClassrooms:VEOPannel
{
    public override void Awake()
    {
        base.Awake();
        _panoramaIdToInteraction = new List<byte>() { 4,22,29,39 };    
    }
    public override void SetActiveOwnedObjectOnPanoramaSet(BelongableTag targetTag, bool isActive, byte targetPlane)
    {
        if(!_panoramaIdToInteraction.Contains(targetPlane))
            return;
        base.SetActiveOwnedObjectOnPanoramaSet(targetTag, isActive, targetPlane);
    }
}