using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ManagerPlaneAction : MonoBehaviour
{
    protected List<IPlaneAction> _planes = new List<IPlaneAction>();

    protected virtual void Awake()
    {
        _planes = GetComponentsInChildren<IPlaneAction>().ToList();
    }

    public void RegisterFuncOnPlaneEnter(Action<byte> targetFunction)
    {
        _planes.ForEach(plane=>plane.OnMousePlaneEnter+=targetFunction);
    }
    public void RegisterFuncOnPlaneExit(Action targetFunction)
    {
        _planes.ForEach(plane=>plane.OnMousePlaneExit+=targetFunction);
    }
    public void RegisterFuncOnPlaneSelected(Action<byte> targetFunction)
    {
        _planes.ForEach(plane=>plane.OnMousePlaneSelected+=targetFunction);
    }
    
}
