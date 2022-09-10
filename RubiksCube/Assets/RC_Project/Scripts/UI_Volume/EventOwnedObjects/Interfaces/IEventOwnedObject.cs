public interface IEventOwnedObject
{
    BelongableTag _currentTag { get; }
    void SetActiveOnPanoramaSetOwnedObject(BelongableTag targetTag, bool isActive, byte targetPlane);
    void SetActiveStatusOwnedObject(BelongableTag targetTag, bool isActive);
}
