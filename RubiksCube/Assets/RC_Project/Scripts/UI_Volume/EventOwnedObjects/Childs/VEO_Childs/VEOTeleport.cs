 using System.Collections.Generic;

 public class VEOTeleport: VolumeEventOwnedObject
 {
     private List<byte> _panoramaIdToInteraction = new List<byte>()
     {

     };
     public override void SetActiveOnPanoramaSetOwnedObject(BelongableTag targetTag, bool isActive, byte targetPlane)
     {
         base.SetActiveOnPanoramaSetOwnedObject(targetTag, isActive, targetPlane);
     }
 }
