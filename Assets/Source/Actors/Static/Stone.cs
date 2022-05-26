using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class Stone : Actor
    {
        protected override int DefaultSpriteId => 100;
        public override string DefaultName
        {
            get => "Stone";
            set { }
        }

        protected override bool OnCollision(Actor anotherActor)
        {
            return false;
        }
    }
}
