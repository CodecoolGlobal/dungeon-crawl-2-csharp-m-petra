using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class Labirynth : Actor
    {
        protected override int DefaultSpriteId
        {
            get => 546;
            set => throw new System.NotImplementedException();
        }

        public override string DefaultName
        {
            get => "Labirynth";
            set { }
        }
    }
}
