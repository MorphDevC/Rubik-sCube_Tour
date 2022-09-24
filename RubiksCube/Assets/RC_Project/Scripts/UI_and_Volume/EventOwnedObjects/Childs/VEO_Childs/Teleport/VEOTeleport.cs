 using System.Collections.Generic;

 public class VEOTeleport: VolumeEventOwnedObject
 {
     private List<byte> _panoramaIdToInteraction = new List<byte>()
     {
         5,17,25,36,43
     };
     public override void SetActiveOwnedObjectOnPanoramaSet(BelongableTag targetTag, bool isActive, byte targetPlane)
     {
         if(!_panoramaIdToInteraction.Contains(targetPlane))
             return;
         base.SetActiveOwnedObjectOnPanoramaSet(targetTag, isActive, targetPlane);
         SetChildObjectsInScene(targetPlane);
     }

     protected override void SetChildObjectsInScene(byte targetPlane)
     {
         base.SetChildObjectsInScene(targetPlane);
     }
     
 }
