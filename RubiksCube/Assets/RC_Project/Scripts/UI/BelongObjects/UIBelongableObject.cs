using System;
using UnityEngine;

public class UIBelongableObject : MonoBehaviour, IUIBelongableObject
{
    [SerializeField]private BelongableTag _unityTag;
    public BelongableTag _currentTag { get; private set; }

    private void Awake()
    {
        _currentTag = _unityTag;
    }

    public void SetActiveBelongableObject(BelongableTag targetTag,bool isActive)
    {
        if(targetTag==_currentTag)
            this.gameObject.SetActive(isActive);
        else
            this.gameObject.SetActive(!isActive);
    }
}
