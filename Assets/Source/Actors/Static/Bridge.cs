using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class Bridge : Actor
    {
        public override int Z => -2;
        public override int DefaultSpriteId => 197;
        public override string DefaultName
        {
            get => "Bridge";
            set { }
        }

        public override bool OnCollision(Actor anotherActor)
        {
            return true;
        }
    }
}
