using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class Spider : Actor
    {
        protected override int DefaultSpriteId => 267;
        public override string DefaultName
        {
            get => "Spider";
            set { }
        }
    }
}
