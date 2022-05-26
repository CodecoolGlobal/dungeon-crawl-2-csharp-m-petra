using DungeonCrawl.Actors;
using DungeonCrawl.Actors.Characters;

namespace Assets.Source.Actors.Static
{
    public class RedWall : Actor
    {
        protected override int DefaultSpriteId
        {
            get => 564;
            set => throw new System.NotImplementedException();
        }

        public override string DefaultName
        {
            get => "RedWall";
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
