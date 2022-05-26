using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class Grass : Actor
    {
        protected override int DefaultSpriteId
        {
            get => 6;
            set => throw new System.NotImplementedException();
        }

        public override string DefaultName
        {
            get => "Grass";
            set { }
        }
    }
}
