  using System.Collections.Generic;
  using System.Linq;
  using UnityEngine;

  public class VEOTeleport: VolumeEventOwnedObject
  {
      public override void Awake()
      {
          base.Awake();
          VolumeObjectDataTransform = new Dictionary<byte, List<VolumeObjectData>>()
          {
              {5, new List<VolumeObjectData> {
                  new VolumeObjectData(new Vector3(377, 9, -147),new Vector3(-90, 0, 0),36)
              }},

              {17, new List<VolumeObjectData> {
                  new VolumeObjectData(new Vector3(390, 10, -50),new Vector3(-90, 0, 0),43)
              }},

              {25, new List<VolumeObjectData> {
                  new VolumeObjectData(new Vector3(148, 4, 10),new Vector3(-90, 0, 0),36)
              }},

              {36, new List<VolumeObjectData>{ 
                  new VolumeObjectData(new Vector3(355, -13, 20), new Vector3(-90,0,0),25),
                  new VolumeObjectData(new Vector3(148, 2, -11), new Vector3(-90,0,0),5)
              }},

              {43, new List<VolumeObjectData> {
                  new VolumeObjectData(new Vector3(110, 0, -84),new Vector3(-90, 0, 0),17)
              }},
          };
      }

      public override void SetActiveOwnedObjectOnPanoramaSet(BelongableTag targetTag, bool isActive, byte targetPlane)
     {
         if(!VolumeObjectDataTransform.ContainsKey(targetPlane)) return;
         base.SetActiveOwnedObjectOnPanoramaSet(targetTag, isActive, targetPlane);
         SetObjectsInScene(targetPlane);
         
         InvokeEventOnPanelSet(VolumeObjectDataTransform[targetPlane].AggregateByField());
     }

 }
