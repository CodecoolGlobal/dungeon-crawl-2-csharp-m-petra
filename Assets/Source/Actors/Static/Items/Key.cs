using Assets.Source.Actors.Static;

namespace DungeonCrawl.Actors.Static
{
    public class Key : Item
    {
        protected override int DefaultSpriteId => 559;
        public override string DefaultName
        {
            get => "Key";
            set { }
        }
    }
}
