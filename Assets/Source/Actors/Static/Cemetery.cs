using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class Cemetery : Actor
    {
        protected override int DefaultSpriteId => 672;
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
