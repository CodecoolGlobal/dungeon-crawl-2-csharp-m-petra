using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{

    public class Spider : Actor
    {
        public override int DefaultSpriteId => 267;
        public override string DefaultName
        {
            get => "Spider";
            set { }
        }
        public override bool OnCollision(Actor anotherActor)
        {
            return true;
        }
    }
}
