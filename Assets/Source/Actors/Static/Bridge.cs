using DungeonCrawl.Actors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Source.Actors.Static
{
    public class Bridge : Actor
    {
        public override int Z => -2;
        public override int DefaultSpriteId => 197;
        public override string DefaultName => "Bridge";
        public override bool OnCollision(Actor anotherActor)
        {
            return true;
        }
    }
}
