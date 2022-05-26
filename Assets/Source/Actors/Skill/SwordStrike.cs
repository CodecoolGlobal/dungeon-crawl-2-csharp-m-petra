using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Skill
{
    public class SwordStrike : Actor
    {
        protected override int Z => -2;
        protected override int DefaultSpriteId => 552;
        public override string DefaultName
        {
            get => "SwordStrike";
            set { }
        }

        public override bool Detectable { get; } = false;
    }
}
