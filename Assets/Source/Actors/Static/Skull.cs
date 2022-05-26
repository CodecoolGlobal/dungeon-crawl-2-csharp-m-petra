using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class Skull : Actor
    {
        protected override int DefaultSpriteId
        {
            get => 720;
            set => throw new System.NotImplementedException();
        }

        public override string DefaultName
        {
            get => "Skull";
            set { }
        }

        protected override bool OnCollision(Actor anotherActor)
        {
            return false;
        }
    }
}
