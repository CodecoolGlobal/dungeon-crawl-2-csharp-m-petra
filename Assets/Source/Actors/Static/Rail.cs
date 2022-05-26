using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class Rail : Actor
    {
        protected override int DefaultSpriteId
        {
            get => 967;
            set => throw new NotImplementedException();
        }

        public override string DefaultName
        {
            get => "Rail";
            set { }
        }

        protected override bool OnCollision(Actor anotherActor)
        {
            return false;
        }
    }
}
