using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class Forest : Actor
    {
        protected override int DefaultSpriteId => 102;
        public override string DefaultName
        {
            get => "Forest";
            set { }
        }

        protected override bool OnCollision(Actor anotherActor)
        {
            return false;
        }
    }
}
