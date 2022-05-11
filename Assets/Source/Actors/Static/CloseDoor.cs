using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawl.Actors;
using DungeonCrawl.Core;

namespace Assets.Source.Actors.Static
{
    public class CloseDoor : Actor
    {
        public override int DefaultSpriteId => 434;
        public override string DefaultName => "CloseDoor";
        public override bool OnCollision(Actor anotherActor)
        {
            //TODO if inventory contains a key
            if (true)
            {
                ActorManager.Singleton.DestroyActor(this);
                ActorManager.Singleton.Spawn<OpenDoor>((10,-14));
                return true;
            }
            return false;
        }
    }
}
