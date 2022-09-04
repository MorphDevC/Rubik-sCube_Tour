using System;
using UnityEngine;

public class BelongableObject : MonoBehaviour, IBelongableObject
{
    [SerializeField]private BelongableTag _unityTag;
    public BelongableTag _currentTag { get; private set; }

    public virtual void Awake()
    {
        _currentTag = _unityTag;
    }

    public virtual void SetActiveBelongableObject(BelongableTag targetTag,bool isActive)
    {
        if(targetTag==_currentTag)
            this.gameObject.SetActive(isActive);
        else
            this.gameObject.SetActive(!isActive);
    }
}
