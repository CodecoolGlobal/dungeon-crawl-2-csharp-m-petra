using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
   
    public class Cactus : Actor
    {
        public override int DefaultSpriteId => 53;
        public override string DefaultName => "Cactus";
        public override bool OnCollision(Actor anotherActor)
        {
            return true;
        }
    }
}
