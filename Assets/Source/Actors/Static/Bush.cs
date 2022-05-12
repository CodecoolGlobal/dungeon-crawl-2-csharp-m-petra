using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class Bush : Actor
    {
        public override int DefaultSpriteId => 95;
        public override string DefaultName
        {
            get => "Bush";
            set { }
        }

        public override bool OnCollision(Actor anotherActor)
        {
            return false;
        }
    }
}
