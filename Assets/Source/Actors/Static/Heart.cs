using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Source.Core;
using DungeonCrawl.Actors;
using DungeonCrawl.Actors.Characters;
using DungeonCrawl.Core;


namespace Assets.Source.Actors.Static
{
    public class Heart : Actor
    {
        public override int DefaultSpriteId => 518;
        public override string DefaultName
        {
            get => "Heart";
            set { }
        }

        public override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player player)
            {
                player.Health += 5;
                player.DisplayHealth(false);
                ActorManager.Singleton.DestroyActor(this);
            }

            return true;
        }
    }

}
