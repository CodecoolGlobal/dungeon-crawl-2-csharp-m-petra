using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{

    public class Cemetery : Actor
    {
        public override int DefaultSpriteId => 672;
        public override string DefaultName => "Cemetery";
        public override bool OnCollision(Actor anotherActor)
        {
            return true;
        }
    }
    
}
