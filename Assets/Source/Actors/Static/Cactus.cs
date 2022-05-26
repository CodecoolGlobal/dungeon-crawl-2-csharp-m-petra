using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class Cactus : Actor
    {
        protected override int DefaultSpriteId
        {
            get => 53;
            set => throw new System.NotImplementedException();
        }

        public override string DefaultName
        {
            get => "Cactus";
            set { }
        }

        protected override bool OnCollision(Actor anotherActor)
        {
            return false;
        }
    }
}
