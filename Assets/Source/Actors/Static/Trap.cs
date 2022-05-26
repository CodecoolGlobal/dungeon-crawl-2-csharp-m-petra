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
    public class Trap : Actor
    {
        protected override int DefaultSpriteId => 118;
        public override string DefaultName
        {
            get => "Trap";
            set { }
        }

        protected override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is not Player player) return false;
            player.Health -= 4;
            player.DisplayHealth();
            if (player.Health <= 0)
            {
                ActorManager.Singleton.DestroyActor(player);
            }
            return true;


        }
    }
}
