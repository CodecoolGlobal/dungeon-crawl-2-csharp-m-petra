using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class Spider : Actor
    {
        protected override int DefaultSpriteId
        {
            get => 267;
            set => throw new System.NotImplementedException();
        }

        public override string DefaultName
        {
            get => "Spider";
            set { }
        }

        protected override bool OnCollision(Actor anotherActor)
        {
            return false;
        }
    }
}
