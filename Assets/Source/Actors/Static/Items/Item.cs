using Assets.Source.Core;
using DungeonCrawl.Actors;
using DungeonCrawl.Actors.Characters;
using UnityEngine;

namespace Assets.Source.Actors.Static
{
    public abstract class Item : Actor
    {
        protected override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player)
            {

                UserInterface.Singleton.SetText("Press E to pick up", UserInterface.TextPosition.BottomRight);
                Sounds("findItem");

            }
            return true;
        }
    }
}
