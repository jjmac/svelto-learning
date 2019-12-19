using UnityEngine;

namespace ECS.Components
{
    public interface ICameraTargetComponent
    {
        Vector3 position { get; }
    }
}