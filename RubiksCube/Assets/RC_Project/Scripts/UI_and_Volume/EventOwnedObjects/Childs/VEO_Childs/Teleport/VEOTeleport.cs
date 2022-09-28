  public class VEOTeleport: VolumeEventOwnedObject
 {
     public override void SetActiveOwnedObjectOnPanoramaSet(BelongableTag targetTag, bool isActive, byte targetPlane)
     {
         base.SetActiveOwnedObjectOnPanoramaSet(targetTag, isActive, targetPlane);
         SetChildObjectsInScene(targetPlane);
         if(!IsObjectSet)
             InvokeEventOnPanelSet(_panoramaIdToInteraction.GetListExpectValue(targetPlane));
     }

 }
