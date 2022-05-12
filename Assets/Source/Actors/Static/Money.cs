using Assets.Source.Core;
using DungeonCrawl.Actors;
using DungeonCrawl.Actors.Characters;
using DungeonCrawl.Core;
using UnityEngine;

namespace Assets.Source.Actors.Static
{
    public class Money : Actor
    {
        protected override int DefaultSpriteId => 232;
        public override string DefaultName
        {
            get => "Money";
            set { }
        }

        protected override bool OnCollision(Actor anotherActor)
        {
            
            if (anotherActor is Player player)
            {
                player.Sounds("pickUp");
                player.Money += 45;
                UserInterface.Singleton.SetText($"Money:  {player.Money} $", UserInterface.TextPosition.BottomCenter);
                ActorManager.Singleton.DestroyActor(this);
            }

            return true;
        }
    }
}
