using DungeonCrawl.Actors;
using DungeonCrawl.Actors.Characters;
using DungeonCrawl.Actors.Static;
using DungeonCrawl.Core;
using System.Linq;

namespace Assets.Source.Actors.Static
{
    public class CloseDoor : Actor
    {
        public override int DefaultSpriteId => 434;
        public override string DefaultName
        {
            get => "CloseDoor";
            set { }
        }

        public override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player player)
            {
                if (player.Inventory.Any(x => x is Key))
                {
                    ActorManager.Singleton.DestroyActor(this);
                    ActorManager.Singleton.Spawn<OpenDoor>((this.Position));
                    return true;
                }
            }
            return false;
        }
    }
}
