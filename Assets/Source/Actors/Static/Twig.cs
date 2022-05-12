
using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{

    public class Twig : Actor
    {
        public override int DefaultSpriteId => 101;
        public override string DefaultName
        {
            get => "Twig";
            set { }
        }
        public override bool OnCollision(Actor anotherActor)
        {
            return true;
        }
    }

}
