using UnityEngine;

namespace ECS.Components
{
    /// <summary>
    /// The speed of an Entity
    /// </summary>
    public interface ISpeedComponent
    {
        float movementSpeed { get; }
    }
}