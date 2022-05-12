using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class FenceHor : Actor
    {
        protected override int DefaultSpriteId => 152;
        public override string DefaultName
        {
            get => "FenceHor";
            set { }
        }

        protected override bool OnCollision(Actor anotherActor)
        {
            return false;
        }
    }
}
