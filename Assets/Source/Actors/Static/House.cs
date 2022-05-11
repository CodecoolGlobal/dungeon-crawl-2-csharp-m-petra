using DungeonCrawl.Actors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Source.Actors.Static
{

    public class House : Actor
    {
        public override int DefaultSpriteId => 963;
        public override string DefaultName => "House";
        public override bool OnCollision(Actor anotherActor)
        {
            return true;
        }
    }
}
