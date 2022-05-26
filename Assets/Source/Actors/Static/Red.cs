using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DungeonCrawl.Actors;
using DungeonCrawl.Actors.Characters;

namespace Assets.Source.Actors.Static
{
    public class Red : Actor
    {
        protected override int DefaultSpriteId
        {
            get => 533;
            set => throw new NotImplementedException();
        }

        public override string DefaultName
        {
            get => "Red";
            set { }
        }

        protected override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player player)
            {
                switch (player.Name)
                {
                    case "ELMAZ":
                    case "PETRA":
                    case "BALINT":
                    case "BENCE":
                    case "KRISZ":
                    case "MATYI":
                        return true;
                }
            }
            return false;
        }
    }
 
}
