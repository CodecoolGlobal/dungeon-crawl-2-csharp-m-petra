using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class SideWalk : Actor
    {
        public override int DefaultSpriteId => 0;
        public override string DefaultName
        {
            get => "SideWalk";
            set { }
        }
        public override bool OnCollision(Actor anotherActor)
        {
            return true;
        }
    }
}
