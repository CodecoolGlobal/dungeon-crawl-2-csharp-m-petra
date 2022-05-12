using DungeonCrawl.Actors.Characters;

namespace DungeonCrawl.Actors.Static
{
    public class Stair : Actor
    {
        public override int DefaultSpriteId => 287;
        public override string DefaultName
        {
            get => "Stair";
            set { }
        }

        public override bool Detectable => true;
        public override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player)
            {
                
                return true;
            }

            return false;
        }
    }
}
