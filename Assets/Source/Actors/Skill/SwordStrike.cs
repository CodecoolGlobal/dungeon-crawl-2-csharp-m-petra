﻿using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Skill
{
    public class SwordStrike : Actor
    {
        protected override int Z => -2;
        protected override int DefaultSpriteId
        {
            get => 552;
            set => throw new System.NotImplementedException();
        }

        public override string DefaultName
        {
            get => "SwordStrike";
            set { }
        }

        public override bool Detectable { get; set; } = false;
    }
}
