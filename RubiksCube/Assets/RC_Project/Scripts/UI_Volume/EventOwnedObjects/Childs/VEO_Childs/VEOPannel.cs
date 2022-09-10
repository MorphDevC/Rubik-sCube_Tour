public class VEOPannel : VolumeEventOwnedObject
{
    public override void SetActiveOnPanoramaSetOwnedObject(BelongableTag targetTag, bool isActive, byte targetPlane)
    {
        base.SetActiveOnPanoramaSetOwnedObject(targetTag, isActive, targetPlane);
    }
}
