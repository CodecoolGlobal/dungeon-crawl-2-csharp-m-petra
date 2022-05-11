using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{

    public class Web : Actor
    {
        public override int DefaultSpriteId => 607;
        public override string DefaultName => "Web";
        public override bool OnCollision(Actor anotherActor)
        {
            return true;
        }
    }
}
