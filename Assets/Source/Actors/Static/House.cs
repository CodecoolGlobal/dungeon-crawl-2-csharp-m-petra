using DungeonCrawl.Actors;
using System;

namespace Assets.Source.Actors.Static
{

    public class House : Actor
    {
        public override int DefaultSpriteId => 963;
        public override string DefaultName
        {
            get => "House";
            set => throw new NotImplementedException();
        }

        public override bool OnCollision(Actor anotherActor)
        {
            return true;
        }
    }
}
