using DungeonCrawl.Actors;
using DungeonCrawl.Actors.Characters;
using DungeonCrawl.Core;

namespace Assets.Source.Actors.Static
{
    public class Heart : Actor
    {
        protected override int DefaultSpriteId => 518;
        public override string DefaultName
        {
            get => "Heart";
            set { }
        }

        protected override int Z => -1;

        protected override bool OnCollision(Actor anotherActor)
        {

            if (anotherActor is Player player)
            {

                player.Sounds("pickUp");
                player.Health += 5;
                player.DisplayHealth();
                ActorManager.Singleton.DestroyActor(this);

            }

            return true;
        }
    }
}
