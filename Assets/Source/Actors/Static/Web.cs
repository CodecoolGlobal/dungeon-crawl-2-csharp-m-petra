using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class Web : Actor
    {
        protected override int DefaultSpriteId
        {
            get => 607;
            set => throw new System.NotImplementedException();
        }

        public override string DefaultName
        {
            get => "Web";
            set { }
        }
        protected override bool OnCollision(Actor anotherActor)
        {
            return false;
        }
    }
}
