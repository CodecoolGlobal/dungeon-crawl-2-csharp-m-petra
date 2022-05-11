using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawl.Actors;
namespace Assets.Source.Actors.Static
{

    public class River : Actor
    {
        public override int DefaultSpriteId => 247;
        public override string DefaultName => "River";
        public override bool OnCollision(Actor anotherActor)
        {
            return true;
        }
    }
}
