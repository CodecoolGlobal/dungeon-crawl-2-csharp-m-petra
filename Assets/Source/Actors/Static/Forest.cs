using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawl.Actors;
namespace Assets.Source.Actors.Static
{
    public class Forest : Actor
    {
        public override int DefaultSpriteId => 47;
        public override string DefaultName => "Forest";
        public override bool OnCollision(Actor anotherActor)
        {
            return true;
        }
    }
}
