using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{

    public class Skull : Actor
    {
        public override int DefaultSpriteId => 720;
        public override string DefaultName
        {
            get => "Skull";
            set { }
        }
        public override bool OnCollision(Actor anotherActor)
        {
            return true;
        }
    }
 
}
