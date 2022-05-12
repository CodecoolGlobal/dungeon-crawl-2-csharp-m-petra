using Assets.Source.Actors.Static;

namespace DungeonCrawl.Actors.Static
{
    public class Key : Item
    {
        public override int DefaultSpriteId => 559;
        public override string DefaultName
        {
            get => "Key";
            set
            { }
        }

        public override int Z => -1;
    }
}
