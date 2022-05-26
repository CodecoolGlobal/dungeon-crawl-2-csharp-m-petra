using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class Stone : Actor
    {
        protected override int DefaultSpriteId
        {
            get => 100;
            set => throw new System.NotImplementedException();
        }

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
