using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{

    public class Cactus : Actor
    {
        public override int DefaultSpriteId => 53;
        public override string DefaultName
        {
            get
            {
                return "Cactus";
            }
            set { }
        }

        public override bool OnCollision(Actor anotherActor)
        {
            return true;
        }
    }
}
