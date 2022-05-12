using DungeonCrawl.Actors.Characters;

namespace DungeonCrawl.Actors.Static
{
    public class Wall : Actor
    {
        protected override int DefaultSpriteId => 825;
        public override string DefaultName
        {
            get => "Wall";
            set { }
        }

        protected override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player player)
            {
                switch (player.Name)
                {
                    case "ELMAZ":
                    case "PETRA":
                    case "BALINT":
                    case "BENCE":
                    case "KRISZ":
                    case "MATYI":
                        return true;
                }
            }
            return false;
        }
    }
}
