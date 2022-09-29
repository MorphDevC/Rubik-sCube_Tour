using System.Collections.Generic;

public class VEOPannelChillouts:VEOPannel
{
    public override void Awake()
    {
        base.Awake();
        _panoramaIdToInteraction = new List<byte>() { 9,30,37,47 };    
    }

    public override void SetActiveOwnedObjectOnPanoramaSet(BelongableTag targetTag, bool isActive, byte targetPlane)
    {
        if(!_panoramaIdToInteraction.Contains(targetPlane))
        {
            if(gameObject.activeInHierarchy)
                SetActiveStatusOwnedObject(targetTag, false);
            return;
        }
        base.SetActiveOwnedObjectOnPanoramaSet(targetTag, isActive, targetPlane);
    }
}

