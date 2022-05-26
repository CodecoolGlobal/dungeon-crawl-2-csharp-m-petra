using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class River : Actor
    {
        protected override int DefaultSpriteId
        {
            get => 247;
            set => throw new System.NotImplementedException();
        }

        public override string DefaultName
        {
            get => "River";
            set { }
        }

        protected override bool OnCollision(Actor anotherActor)
        {
            return false;
        }
    }
}
