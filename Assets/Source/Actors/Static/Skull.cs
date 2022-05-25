using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class Skull : Actor
    {
        protected override int DefaultSpriteId => 720;
        public override string DefaultName
        {
            get => "Skull";
            set { }
        }

        protected override bool OnCollision(Actor anotherActor)
        {
            return false;
        }
    }
}
