using System;
using UnityEngine;


[RequireComponent(typeof(Renderer))]
public class PlaneAction : MonoBehaviour, IPlaneAction
{
    public byte PlaneNumber { get; protected set; }
    public Renderer InteractionMaterial { get; private set; }
    
    public event Action<byte> OnMousePlaneEnter;
    public event Action OnMousePlaneExit;
    public event Action<byte> OnMousePlaneSelected;

    public virtual void Awake()
    {
        (InteractionMaterial = GetComponent<Renderer>()).DelayEmission();
        //InteractionMaterial.DelayEmission();
    }
    public virtual void OnMouseEnter()
    {
        InteractionMaterial.EnableEmission();
        OnMousePlaneEnter?.Invoke(PlaneNumber);
    }

    public virtual void OnMouseExit()
    {
        InteractionMaterial.DisableEmission();
        OnMousePlaneExit?.Invoke();
    }

    public virtual void OnMouseUp()
    {
        OnMouseExit();
        OnMousePlaneSelected?.Invoke(PlaneNumber);
    }

    public void SetPlaneNumber(byte targetId) => PlaneNumber = targetId;
}

