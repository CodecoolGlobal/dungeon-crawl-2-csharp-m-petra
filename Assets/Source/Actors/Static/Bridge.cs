using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class Bridge : Actor
    {
        protected override int Z => -2;
        protected override int DefaultSpriteId
        {
            get => 197;
            set => throw new System.NotImplementedException();
        }

        public override string DefaultName
        {
            get => "Bridge";
            set { }
        }
    }
}
