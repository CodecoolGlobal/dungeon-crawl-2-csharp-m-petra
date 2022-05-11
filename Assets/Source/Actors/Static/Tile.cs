using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class Tile : Actor
    {
        public override int DefaultSpriteId => 106;
        public override string DefaultName => "Tile";
        public override bool OnCollision(Actor anotherActor)
        {
            return true;
        }
    }
}
