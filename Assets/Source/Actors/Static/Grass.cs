using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class Grass : Actor
    {
        protected override int DefaultSpriteId => 6;
        public override string DefaultName
        {
            get => "Grass";
            set { }
        }
    }
}
