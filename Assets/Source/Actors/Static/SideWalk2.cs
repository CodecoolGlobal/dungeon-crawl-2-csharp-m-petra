using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{

    public class SideWalk2 : Actor
    {
        public override int DefaultSpriteId => 667;
        public override string DefaultName => "SideWalk2";
        public override bool OnCollision(Actor anotherActor)
        {
            return true;
        }
    }
    
}
