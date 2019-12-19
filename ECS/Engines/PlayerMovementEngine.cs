using System.Collections;
using Svelto.Tasks;
using UnityEngine;

namespace ECS.Engines
{
    public class PlayerMovementEngine : IQueryingEntitiesEngine
    {
        
        public IEntitiesDB entitiesDB { private get; set; }

        public void Ready()
        {
            PhysicsTick().RunOnScheduler(StandardSchedulers.physicScheduler);
        }
        
        IEnumerator PhysicsTick()
        {
            while (true)
            {
                var playerEntities = entitiesDB.QueryEntities<PlayerEntityViewStruct, PlayerInputDataStruct>(
                        ECSGroups.Player,
                        out var count);

                for (var i = 0; i < count; i++)
                {
                    // Movement(ref playerEntities.Item2[i], ref playerEntities.Item1[i]);
                    // Turning(ref playerEntities.Item2[i], ref playerEntities.Item1[i]);
                }

                yield return null;
            }
        }
    }
}