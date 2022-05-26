using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class Cat : Actor
    {
        protected override int DefaultSpriteId
        {
            get => 364;
            set => throw new NotImplementedException();
        }

        public override string DefaultName
        {
            get => "Cat";
            set { }
        }

        protected override bool OnCollision(Actor anotherActor)
        {
            return false;
        }
    }

}
