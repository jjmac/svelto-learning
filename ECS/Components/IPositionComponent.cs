using UnityEngine;

namespace ECS.Components
{
    /// <summary>
    /// The position of an Entity
    /// </summary>
    public interface IPositionComponent
    {
        Vector3 position { get; }
    }
}