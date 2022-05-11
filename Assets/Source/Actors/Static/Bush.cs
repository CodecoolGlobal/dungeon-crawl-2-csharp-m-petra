using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class Bush : Actor
    {
        public override int DefaultSpriteId => 96;
        public override string DefaultName => "Bush";
        public override bool OnCollision(Actor anotherActor)
        {
            return true;
        }
    }

}
