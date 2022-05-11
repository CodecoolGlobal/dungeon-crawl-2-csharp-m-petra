using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class FenceVer : Actor
    {
        public override int DefaultSpriteId => 205;
        public override string DefaultName
        {
            get => "FenceVer";
            set { }
        }
        public override bool OnCollision(Actor anotherActor)
        {
            return false;
        }
    }
}
