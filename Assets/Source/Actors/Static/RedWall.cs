using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class RedWall : Actor
    {
        public override int DefaultSpriteId => 564; 
        public override string DefaultName
        {
            get => "RedWall";
            set { }
        }
        public override bool OnCollision(Actor anotherActor)
        {
            return false;
        }
    }
}
