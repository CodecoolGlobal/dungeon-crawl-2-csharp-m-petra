using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class Bush : Actor
    {
        protected override int DefaultSpriteId
        {
            get => 95;
            set => throw new System.NotImplementedException();
        }

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
