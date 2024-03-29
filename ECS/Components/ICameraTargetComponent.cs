using UnityEngine;

namespace ECS.Components
{
    /// <summary>
    /// This is the target that the camera is looking at.
    /// </summary>
    public interface ICameraTargetComponent
    {
        Vector3 position { get; }
    }
}