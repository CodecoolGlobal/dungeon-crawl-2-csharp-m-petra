﻿using DungeonCrawl.Actors;
using DungeonCrawl.Actors.Characters;
using DungeonCrawl.Actors.Static;
using DungeonCrawl.Core;
using System.Linq;

namespace Assets.Source.Actors.Static
{
    public class CloseDoor : Actor
    {
        protected override int DefaultSpriteId
        {
            get => 434;
            set => throw new System.NotImplementedException();
        }

        public override string DefaultName
        {
            get => "CloseDoor";
            set { }
        }

        protected override bool OnCollision(Actor anotherActor)
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
            Sounds("door");
            return false;
        }
    }
}
