using System;

public class VolumeBelongableObject : BelongableObject
{
    public override void Awake()
    {
        base.Awake();
    }
    
    public override void SetActiveBelongableObject(BelongableTag targetTag, bool isActive)
    {
        base.SetActiveBelongableObject(targetTag, isActive);
    }
}