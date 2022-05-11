using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{

    public class Twig : Actor
    {
        public override int DefaultSpriteId => 101;
        public override string DefaultName => "Twig";
        public override bool OnCollision(Actor anotherActor)
        {
            return true;
        }
    }

}
