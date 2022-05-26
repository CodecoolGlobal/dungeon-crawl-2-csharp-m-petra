using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class FenceHor : Actor
    {
        protected override int DefaultSpriteId
        {
            get => 152;
            set => throw new System.NotImplementedException();
        }

        public override string DefaultName
        {
            get => "FenceHor";
            set { }
        }

        protected override bool OnCollision(Actor anotherActor)
        {
            return false;
        }
    }
}
