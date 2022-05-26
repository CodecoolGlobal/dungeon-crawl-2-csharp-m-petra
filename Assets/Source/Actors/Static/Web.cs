using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class Web : Actor
    {
        protected override int DefaultSpriteId => 607;
        public override string DefaultName
        {
            get => "Web";
            set { }
        }
        protected override bool OnCollision(Actor anotherActor)
        {
            return false;
        }
    }
}
