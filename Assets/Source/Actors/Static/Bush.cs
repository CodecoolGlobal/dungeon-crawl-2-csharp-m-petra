using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class Bush : Actor
    {
        public override int DefaultSpriteId => 96;
        public override string DefaultName
        {
            get => "Bush";
            set { }
        }

        public override bool OnCollision(Actor anotherActor)
        {
            return true;
        }
    }

}
