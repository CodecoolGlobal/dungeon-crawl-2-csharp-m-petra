using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class Bridge : Actor
    {
        protected override int Z => -2;
        protected override int DefaultSpriteId => 197;
        public override string DefaultName
        {
            get => "Bridge";
            set { }
        }
    }
}
