using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class Tile : Actor
    {
        protected override int DefaultSpriteId
        {
            get => 106;
            set => throw new System.NotImplementedException();
        }

        public override string DefaultName
        {
            get => "Tile";
            set { }
        }
    }
}
