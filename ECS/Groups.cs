using Svelto.ECS;

namespace ECS {
    static class Groups {
        // This setup expects a single player on the current device.
        public static readonly ExclusiveGroup Player = new ExclusiveGroup();

        // The camera target is the player.
        public static readonly ExclusiveGroup CameraTarget = Player;
    }
}