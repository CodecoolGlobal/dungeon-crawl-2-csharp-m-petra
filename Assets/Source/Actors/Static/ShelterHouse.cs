using Assets.Source.Core;
using DungeonCrawl.Actors;
using DungeonCrawl.Actors.Characters;
using UnityEngine;

namespace Assets.Source.Actors.Static
{
    public class ShelterHouse : Actor
    {
        protected override int DefaultSpriteId => 912;
        public override string DefaultName
        {
            get => "ShelterHouse";
            set { }
        }

        protected override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player player)
            {
                Sounds("you_win");
                UserInterface.Singleton.SetText("YOU WIN", UserInterface.TextPosition.MiddleRight);
                return false;
            }

            return false;
        }
    }
}
