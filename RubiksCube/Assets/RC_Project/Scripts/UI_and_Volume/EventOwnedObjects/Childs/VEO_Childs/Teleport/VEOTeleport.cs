  using System.Collections.Generic;
  using UnityEngine;

  public class VEOTeleport: VolumeEventOwnedObject
  {
      public override void Awake()
      {
          base.Awake();
          VolumeObjectDataTransform = new Dictionary<byte, List<VolumeObjectData>>()
          {
              {5, new List<VolumeObjectData> {
                  new VolumeObjectData(new Vector3(377, 9, -147),new Vector3(-90, 0, 0))
              }},

              {17, new List<VolumeObjectData> {
                  new VolumeObjectData(new Vector3(390, 10, -50),new Vector3(-90, 0, 0))
              }},

              {25, new List<VolumeObjectData> {
                  new VolumeObjectData(new Vector3(148, 4, 10),new Vector3(-90, 0, 0))
              }},

              {36, new List<VolumeObjectData>{ 
                  new VolumeObjectData(new Vector3(355, -13, 20), new Vector3(-90,0,0)),
                  new VolumeObjectData(new Vector3(148, 2, -11), new Vector3(-90,0,0))
              }},

              {43, new List<VolumeObjectData> {
                  new VolumeObjectData(new Vector3(110, 0, -84),new Vector3(-90, 0, 0))
              }},
          };
      }

      public override void SetActiveOwnedObjectOnPanoramaSet(BelongableTag targetTag, bool isActive, byte targetPlane)
     {
         base.SetActiveOwnedObjectOnPanoramaSet(targetTag, isActive, targetPlane);
         SetChildObjectsInScene(targetPlane);
         if(!IsObjectSet)
             InvokeEventOnPanelSet(_panoramaIdToInteraction.GetListExpectValue(targetPlane));
     }

 }
