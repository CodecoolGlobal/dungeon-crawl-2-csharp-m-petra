using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class Forest : Actor
    {
        protected override int DefaultSpriteId
        {
            get => 102;
            set => throw new System.NotImplementedException();
        }

        public override string DefaultName
        {
            get => "Forest";
            set { }
        }

        protected override bool OnCollision(Actor anotherActor)
        {
            return false;
        }
    }
}
