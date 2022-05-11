using DungeonCrawl.Actors;
namespace Assets.Source.Actors.Static
{
    public class Forest : Actor
    {
        public override int DefaultSpriteId => 102;
        public override string DefaultName
        {
            get => "Forest";
            set { }
        }

        public override bool OnCollision(Actor anotherActor)
        {
            return false;
        }
    }
}
