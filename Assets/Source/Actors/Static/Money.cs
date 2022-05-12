using Assets.Source.Core;
using DungeonCrawl.Actors;
using DungeonCrawl.Actors.Characters;
using DungeonCrawl.Core;

namespace Assets.Source.Actors.Static
{
    public class Money : Actor
    {
        public override int DefaultSpriteId => 232;
        public override string DefaultName
        {
            get => "Money";
            set { }
        }

        public override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player player)
            {
                player.Money += 45;
                UserInterface.Singleton.SetText($"Money:  {player.Money} $", UserInterface.TextPosition.BottomCenter);
                ActorManager.Singleton.DestroyActor(this);
            }

            return true;
        }
    }
}
