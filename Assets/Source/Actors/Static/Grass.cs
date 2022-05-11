using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawl.Actors;
namespace Assets.Source.Actors.Static
{
    public class Grass : Actor
    {
        public override int DefaultSpriteId => 6;
        public override string DefaultName => "Grass";
        public override bool OnCollision(Actor anotherActor)
        {
            return true;
        }
    }
}
