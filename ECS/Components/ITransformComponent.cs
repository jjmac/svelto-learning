using UnityEngine;

namespace ECS.Components
{
    /// <summary>
    /// The transform of an Entity.
    /// </summary>
    public interface ITransformComponent
    {
        Vector3 position { get; }
        Quaternion rotation { set; }
    }
}