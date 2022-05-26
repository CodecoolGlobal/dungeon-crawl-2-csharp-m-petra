using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class Car:Actor
    {
        protected override int DefaultSpriteId => 91;
        public override string DefaultName
        {
            get => "Car";
            set { }
        }

        protected override bool OnCollision(Actor anotherActor)
        {
            return false;
        }
    }
}
