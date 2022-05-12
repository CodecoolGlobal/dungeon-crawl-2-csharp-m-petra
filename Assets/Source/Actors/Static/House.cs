using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{

    public class House : Actor
    {
        public override int DefaultSpriteId => 963;
        public override string DefaultName
        {
            get => "House";
            set { }
        }

        public override bool OnCollision(Actor anotherActor)
        {
            return true;
        }
    }
}
