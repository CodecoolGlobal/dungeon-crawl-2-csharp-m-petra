using Assets.Source.Actors.Static;

namespace DungeonCrawl.Actors.Static
{
    public class Sword : Item
    {
        public override int DefaultSpriteId => 415; // 463
        public override string DefaultName
        {
            get => "Sword";
            set => throw new System.NotImplementedException();
        }

        public override int Z => -1;
        public int Attack => 5;
    }
}
