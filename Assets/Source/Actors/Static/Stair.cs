using DungeonCrawl.Actors.Characters;

namespace DungeonCrawl.Actors.Static
{
    public class Stair : Actor
    {
        protected override int DefaultSpriteId
        {
            get => 287;
            set => throw new System.NotImplementedException();
        }

        public override string DefaultName
        {
            get => "Stair";
            set { }
        }

        public override bool Detectable => true;

        protected override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player)
            {

                return true;
            }

            return false;
        }
    }
}
