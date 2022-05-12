using Assets.Source.Actors.Static;

namespace DungeonCrawl.Actors.Static
{
    public class Sword : Item
    {
        protected override int DefaultSpriteId => 415; // 463
        public override string DefaultName
        {
            get => "Sword";
            set { }
        }

        protected override int Z => -1;
        public int Attack => 5;
    }
}
