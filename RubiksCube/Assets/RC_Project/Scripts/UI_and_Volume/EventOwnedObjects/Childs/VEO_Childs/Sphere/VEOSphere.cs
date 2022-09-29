using System.Collections.Generic;
using UnityEngine;

public class VEOSphere: VolumeEventOwnedObject
{
    private List<byte> _panoramaIdToInteraction = new List<byte>()
    {
        3,7,13,15,21,26,34,41
    };//add 37

    public override void Awake()
    {
        base.Awake();
        VolumeObjectDataTransform = new Dictionary<byte, List<VolumeObjectData>>()
        {
            {3, new List<VolumeObjectData>() {
                new VolumeObjectData(new Vector3(137f, 36, -37))
            }},

            {7, new List<VolumeObjectData> {
                new VolumeObjectData(new Vector3(101, 43, -88),Vector3.zero,26),
                new VolumeObjectData(new Vector3(138, 35, -69),Vector3.zero,15)
            }},

            {13, new List<VolumeObjectData> {
                new VolumeObjectData(new Vector3(135, 34, -87.5f),new Vector3(0, 0, 0))
            }},
        
            {15, new List<VolumeObjectData> {
                new VolumeObjectData(new Vector3(93, 39, -36),Vector3.zero,7)
            }},

            {21, new List<VolumeObjectData> { 
                new VolumeObjectData(new Vector3(138, 36, -34), new Vector3(0, 0, 0)),
                new VolumeObjectData(new Vector3(86, 36, -93), new Vector3(0, 0, 0))
            }},

            {26, new List<VolumeObjectData> {
                new VolumeObjectData(new Vector3(86, 43, -76), Vector3.zero,34),
                new VolumeObjectData(new Vector3(101, 27, -81),Vector3.zero,7)
            }},

            {34, new List<VolumeObjectData> {
                new VolumeObjectData(new Vector3(88, 44, -59.5f), Vector3.zero,41),
                new VolumeObjectData(new Vector3(108, 29, -41),Vector3.zero,26)
            }},
            
            {37, new List<VolumeObjectData> {
                new VolumeObjectData(new Vector3(120, 35, -42), Vector3.zero,41)
            }},
        
            {41, new List<VolumeObjectData> {
                new VolumeObjectData(new Vector3(136, 34, -63), Vector3.zero,37),
                new VolumeObjectData(new Vector3(93, 30, -51.8f),Vector3.zero,34)
            }},
        };
    }

    public override void SetActiveOwnedObjectOnPanoramaSet(BelongableTag targetTag, bool isActive, byte targetPlane)
    {
        if(!VolumeObjectDataTransform.ContainsKey(targetPlane))
        {
            if(gameObject.activeInHierarchy)
                SetActiveStatusOwnedObject(targetTag, false);
            return;
        }
        base.SetActiveOwnedObjectOnPanoramaSet(targetTag, isActive, targetPlane);
        SetObjectsInScene(targetPlane);
        InvokeEventOnPanelSet(VolumeObjectDataTransform[targetPlane].AggregateByField());
    }

    protected override void SetObjectsInScene(byte targetPlane)
    {
        base.SetObjectsInScene(targetPlane);
    }
}
