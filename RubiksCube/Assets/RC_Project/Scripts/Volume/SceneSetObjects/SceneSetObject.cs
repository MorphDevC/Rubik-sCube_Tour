using UnityEngine;

public class SceneSetObject:MonoBehaviour,ISceneSetObject
{
    public Transform GetTransform { get; }

    public void SetActiveObject(bool isActive)
    {
        transform.gameObject.SetActive(isActive);
    }
    
    public void SetChildPosition(Vector3 position)
    {
        transform.localPosition = position;
    }
    public void SetChildRotation(Vector3 rotation)
    {
        transform.localEulerAngles = rotation;
    }
}
