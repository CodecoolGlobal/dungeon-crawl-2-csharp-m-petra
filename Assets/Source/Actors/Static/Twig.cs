using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class Twig : Actor
    {
        protected override int DefaultSpriteId
        {
            get => 101;
            set => throw new System.NotImplementedException();
        }

        public override string DefaultName
        {
            get => "Twig";
            set { }
        }
        protected override bool OnCollision(Actor anotherActor)
        {
            return false;
        }
    }
}
