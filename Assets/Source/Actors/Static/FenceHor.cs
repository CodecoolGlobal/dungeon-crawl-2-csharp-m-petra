using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class FenceHor : Actor
    {
        public override int DefaultSpriteId => 152;
        public override string DefaultName
        {
            get => "FenceHor";
            set { }
        }

        public override bool OnCollision(Actor anotherActor)
        {
            return false;
        }
    }
}
