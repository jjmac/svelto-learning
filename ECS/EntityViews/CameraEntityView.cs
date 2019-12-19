using Svelto.ECS.Hybrid;

using ECS.Components;

namespace ECS.EntityViews
{
    public struct CameraEntityView : IEntityViewStruct
    {
        public IPositionComponent  positionComponent;
        public ITransformComponent transformComponent;

        public EGID ID { get; set; }
    }
}