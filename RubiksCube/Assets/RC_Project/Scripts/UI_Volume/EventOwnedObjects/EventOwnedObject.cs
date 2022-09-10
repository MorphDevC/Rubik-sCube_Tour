using System;
using UnityEngine;

public class EventOwnedObject : MonoBehaviour, IEventOwnedObject
{
    [SerializeField]private BelongableTag _unityTag;
    public BelongableTag _currentTag { get; private set; }

    public virtual void Awake()
    {
        _currentTag = _unityTag;
    }

    public virtual void SetActiveOnPanoramaSetOwnedObject(BelongableTag targetTag, bool isActive, byte targetPlane)
    {
        SetActiveStatusOwnedObject(targetTag, isActive);
    }

    public virtual void SetActiveStatusOwnedObject(BelongableTag targetTag, bool isActive)
    {
        if(targetTag==_currentTag)
            this.gameObject.SetActive(isActive);
        else
            this.gameObject.SetActive(!isActive);
    }
}
