using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Source.Core;
using DungeonCrawl.Actors;
using DungeonCrawl.Actors.Characters;

namespace Assets.Source.Actors.Static
{
    public class ShelterHouse : Actor
    {
        public override int DefaultSpriteId => 912;
        public override string DefaultName
        {
            get => "ShelterHouse";
            set { }
        }

        public override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player player)
            {
                UserInterface.Singleton.SetText("YOU WIN", UserInterface.TextPosition.MiddleRight);
                return false;
            }

            return false;
        }
    }

}
