using System;

public class UIEventOwnedObject:EventOwnedObject
{
    public override void Awake()
    {
        base.Awake();
    }
    
    

    public override void SetActiveOnPanoramaSetOwnedObject(BelongableTag targetTag, bool isActive, byte targetPlane)
    {
        base.SetActiveOnPanoramaSetOwnedObject(targetTag, isActive, targetPlane);
    }
}