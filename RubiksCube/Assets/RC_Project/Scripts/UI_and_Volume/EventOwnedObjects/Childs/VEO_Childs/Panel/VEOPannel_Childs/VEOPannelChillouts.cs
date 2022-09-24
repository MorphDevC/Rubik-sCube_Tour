using System.Collections.Generic;

public class VEOPannelChillouts:VEOPannel
{
    private List<byte> _panoramaIdToInteraction = new List<byte>()
    {
        9,30,37,47
    };
    public override void SetActiveOwnedObjectOnPanoramaSet(BelongableTag targetTag, bool isActive, byte targetPlane)
    {
        if(!_panoramaIdToInteraction.Contains(targetPlane))
            return;
        base.SetActiveOwnedObjectOnPanoramaSet(targetTag, isActive, targetPlane);
        if(!IsPanelSet)
            InvokeEventOnPanelSet(_panoramaIdToInteraction);
    }
}

