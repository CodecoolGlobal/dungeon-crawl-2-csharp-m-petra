using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class Red : Actor
    {
        protected override int DefaultSpriteId => 533;
        public override string DefaultName
        {
            get => "Red";
            set { }
        }

        protected override bool OnCollision(Actor anotherActor)
        {
            return false;
        }
    }
 
}
