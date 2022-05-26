using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class House : Actor
    {
        protected override int DefaultSpriteId => 963;
        public override string DefaultName
        {
            get => "House";
            set { }
        }

        protected override bool OnCollision(Actor anotherActor)
        {
            return false;
        }
    }
}
