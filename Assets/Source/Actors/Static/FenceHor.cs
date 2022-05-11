using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class FenceHor : Actor
    {
        public override int DefaultSpriteId => 192;
        public override string DefaultName => "FenceHor";

        public override bool OnCollision(Actor anotherActor)
        {
            return false;
        }
    }
}
