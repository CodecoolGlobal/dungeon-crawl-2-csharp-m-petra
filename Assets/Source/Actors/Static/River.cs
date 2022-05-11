using DungeonCrawl.Actors;
namespace Assets.Source.Actors.Static
{

    public class River : Actor
    {
        public override int DefaultSpriteId => 247;
        public override string DefaultName
        {
            get => "River";
            set { }
        }

        public override bool OnCollision(Actor anotherActor)
        {
            return true;
        }
    }
}
