public interface IEventOwnedObject
{
    BelongableTag _currentTag { get; }
    void SetActiveOwnedObjectOnPanoramaSet(BelongableTag targetTag, bool isActive, byte targetPlane);
    void SetActiveStatusOwnedObject(BelongableTag targetTag, bool isActive);
}
