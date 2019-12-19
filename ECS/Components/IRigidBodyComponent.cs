using UnityEngine;

namespace ECS.Components
{
    /// <summary>
    /// The rigid body of an Entity
    /// </summary>
    public interface IRigidBodyComponent
    {
        bool isKinematic { set; }
    }
}