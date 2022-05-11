﻿namespace DungeonCrawl.Actors.Static
{
    public class Floor : Actor
    {
        public override int DefaultSpriteId => 1;
        public override string DefaultName
        {
            get => "Floor";
            set { }
        }

        public override bool Detectable => false;
    }
}
