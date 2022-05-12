using DungeonCrawl.Actors;
using DungeonCrawl.Actors.Characters;

namespace Assets.Source.Actors.Static
{
    public class RedWall : Actor
    {
        public override int DefaultSpriteId => 564;
        public override string DefaultName
        {
            get => "RedWall";
            set { }
        }
        public override bool OnCollision(Actor anotherActor)
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
