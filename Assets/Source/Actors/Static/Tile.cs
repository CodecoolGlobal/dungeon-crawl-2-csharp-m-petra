using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class Tile : Actor
    {
        public override int DefaultSpriteId => 106;
        public override string DefaultName
        {
            get => "Tile";
            set { }
        }
    }
}
