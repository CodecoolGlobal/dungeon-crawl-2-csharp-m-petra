﻿using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class River : Actor
    {
        protected override int DefaultSpriteId => 247;
        public override string DefaultName
        {
            get => "River";
            set { }
        }

        protected override bool OnCollision(Actor anotherActor)
        {
            return false;
        }
    }
}
