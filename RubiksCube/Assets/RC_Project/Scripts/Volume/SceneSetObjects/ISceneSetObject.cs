using UnityEngine;

public interface ISceneSetObject
{
    Transform GetTransform { get; }

    void SetChildPosition(Vector3 position);
    void SetChildRotation(Vector3 rotation);
    void SetActiveObject(bool isActive);
}
