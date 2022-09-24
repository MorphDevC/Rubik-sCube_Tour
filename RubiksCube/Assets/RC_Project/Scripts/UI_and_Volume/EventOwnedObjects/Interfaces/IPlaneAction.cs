using System;
using UnityEngine;

public interface IPlaneAction
{
    byte PlaneNumber { get; }
    void SetPlaneNumber(byte targetId);
    Renderer InteractionMaterial { get; }
    event Action<byte> OnMousePlaneEnter;
    event Action OnMousePlaneExit;
    event Action<byte> OnMousePlaneSelected;
}
