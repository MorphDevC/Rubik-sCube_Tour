using System;

public class UIEventOwnedObject:EventOwnedObject
{
    public override void Awake()
    {
        base.Awake();
    }
    
    
    public override void SetActiveOwnedObjectOnPanoramaSet(BelongableTag targetTag, bool isActive, byte targetPlane)
    {
        base.SetActiveOwnedObjectOnPanoramaSet(targetTag, isActive, targetPlane);
    }
}