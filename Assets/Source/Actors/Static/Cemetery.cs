using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class Cemetery : Actor
    {
        protected override int DefaultSpriteId
        {
            get => 672;
            set => throw new System.NotImplementedException();
        }

        public override string DefaultName
        {
            get => "Cemetery";
            set { }
        }

        protected override bool OnCollision(Actor anotherActor)
        {
            return false;
        }
    }
}
