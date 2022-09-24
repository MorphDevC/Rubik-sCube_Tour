using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(VEOPannelChillouts))]
[RequireComponent(typeof(VEOPannelClassrooms))]
public class ManagerPanelPlaneAction : ManagerPlaneAction
{
    private List<VEOPannel> _volumeEventOwnedObjectsRef;

    protected override void Awake()
    {
        base.Awake();
        _volumeEventOwnedObjectsRef = GetComponents<VEOPannel>().ToList();
        _volumeEventOwnedObjectsRef.ForEach(reference=>reference.OnSetPanelFromCube+=SetPlanesIdOnPanelSet);
    }

    private void SetPlanesIdOnPanelSet(List<byte> targetIds)
    {
        for (int i = 0; i < targetIds.Count; i++)
        {
            _planes[i].SetPlaneNumber(targetIds[i]);
        }
    }
}
