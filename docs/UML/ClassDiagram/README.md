# Basic UML class diagrams

There is on the diagram base logic of script connection and invoking. [Full UML class diagram](#Full-Diagram) places in the end
 
There are 3 base classes that implement interfaces and the base logic of the project:
- [ManagerPlaneAction](#Manager-Plane-Action)
- [EventOwnedObject](#Event-Owned-Object)
- [PlaneAction](#Plane-Action)

___

## Manager Plane Action

Manager Plane Action is the parent class that Register functions on next Events:
1. OnPlaneEnter
2. OnPlaneExit
3. OnPlanePressed

![image](https://user-images.githubusercontent.com/62260078/193459213-b094e2a4-a667-498d-85ef-bc354dc48f18.png)

In method 'Awake()' this class get components in children type of 'IPlaneAction'
```cs
protected virtual void Awake()
{
    _planes = GetComponentsInChildren<IPlaneAction>().ToList();

    _volumeEventOwnedObjectsRef = GetComponents<VolumeEventOwnedObject>().ToList();
    _volumeEventOwnedObjectsRef.ForEach(reference=>reference.OnSetObjectFromCube+=SetPlanesIdOnPanelSet);
 }
```
That allows to register on every plane target function to invoke based on type of event


### OnPlaneEnter

This event invokes when mouse entered in every single GameObject that has one of inheritor [PlaneAction](#PlaneAction) script.
This event useful to show destination next panorama name

![image](https://user-images.githubusercontent.com/62260078/193460598-a69bc606-daa9-40a4-8aa5-3a90a4c3247f.png)


### OnPlaneExit

This event invokes when mouse exited from every single GameObject that has one of inheritor [PlaneAction](#PlaneAction) script.
This event useful to hide destination next panorama name object

![image](https://user-images.githubusercontent.com/62260078/193460542-baad2d4c-1419-44c5-9971-cac950678682.png)


### OnPlanePressed

This event invokes when the plane has been choosen and player want to see target panorama.
For example on next image class 'PanoramaBehaviour' register function
```cs 
public void ChangePanorama(byte targetIdPlane)
{
    OnPanoramaSetOwnedObjects?.Invoke(BelongableTag.Panorama,true, targetIdPlane);
    StartCoroutine(DownloadCacheView(_panoramaSuppInfo.TargetPanoramaToLoad[targetIdPlane]));
}
```
to set panorama when selected plane has been pressed
![image](https://user-images.githubusercontent.com/62260078/193460161-a851201e-2749-486b-bf6f-f037eae9852d.png)

___

## Event Owned Object

Event Owned Object is the parent class that SetActive UI or Volume objects when some event is invoking.
Now there are 2 states:
1. Panorama on
2. Cube on

Target Gameobject has an assign in which state it SetActive(true) or SetActive(false) based on enum tag

For example, in class 'PanoramaBehaviour.cs' there are events when panorama set and unset. 
'EventOwnedObjectsManager.cs' class register foreach 'IEventOwnedObject.cs' object to function to SetActive(true or false)
![image](https://user-images.githubusercontent.com/62260078/193467155-ee05ef5c-7637-4b1a-ae78-f87355576de4.png)

___

## PlaneAction

'PlaneAction.cs' handles basic interaction events like:
1. OnMouseEnter
2. OnMouseExit
3. OnMousePressed

This class assigns for every interactable object that moves player on next panorama
___

## Full Diagram

![image](https://user-images.githubusercontent.com/62260078/193456555-a176a3f7-c652-4cbe-ad8a-0b6920fe6b38.png)
