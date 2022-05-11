using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawl.Actors;
namespace Assets.Source.Actors.Static
{
    public class Stone : Actor
    {
        public override int DefaultSpriteId => 100;
        public override string DefaultName => "Stone";
        public override bool OnCollision(Actor anotherActor)
        {
            return true;
        }
    }
}
