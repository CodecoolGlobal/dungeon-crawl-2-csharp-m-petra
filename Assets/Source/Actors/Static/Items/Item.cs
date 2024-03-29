﻿using Assets.Source.Core;
using DungeonCrawl.Actors;
using DungeonCrawl.Actors.Characters;

namespace Assets.Source.Actors.Static
{
    public abstract class Item : Actor
    {
        protected override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player)
            {
                UserInterface.Singleton.SetText($"Press E to pick up {DefaultName}", UserInterface.TextPosition.BottomRight);
                Sounds("findItem");

            }
            return true;
        }

        protected override int Z => -1;
    }
}
