public interface IUIBelongableObject
{
    BelongableTag _currentTag { get; }
    void SetActiveBelongableObject(BelongableTag targetTag,bool isActive);
}
