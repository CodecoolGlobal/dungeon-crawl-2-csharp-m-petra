using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class House : Actor
    {
        protected override int DefaultSpriteId
        {
            get => 963;
            set => throw new System.NotImplementedException();
        }

        public override string DefaultName
        {
            get => "House";
            set { }
        }

        protected override bool OnCollision(Actor anotherActor)
        {
            return false;
        }
    }
}
