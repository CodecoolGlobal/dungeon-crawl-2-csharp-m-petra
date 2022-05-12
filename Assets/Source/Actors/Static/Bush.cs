using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class Bush : Actor
    {
        protected override int DefaultSpriteId => 95;
        public override string DefaultName
        {
            get => "Bush";
            set { }
        }

        protected override bool OnCollision(Actor anotherActor)
        {
            return false;
        }
    }
}
