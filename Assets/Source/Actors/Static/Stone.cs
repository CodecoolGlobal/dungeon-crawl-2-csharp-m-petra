using DungeonCrawl.Actors;
using System;
namespace Assets.Source.Actors.Static
{
    public class Stone : Actor
    {
        public override int DefaultSpriteId => 100;
        public override string DefaultName
        {
            get => "Stone";
            set => throw new NotImplementedException();
        }

        public override bool OnCollision(Actor anotherActor)
        {
            return true;
        }
    }
}
