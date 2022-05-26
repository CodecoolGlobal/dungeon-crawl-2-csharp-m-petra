using Assets.Source.Actors.Static;

namespace DungeonCrawl.Actors.Static
{
    public class Key : Item
    {
        protected override int DefaultSpriteId
        {
            get => 559;
            set => throw new System.NotImplementedException();
        }

        public override string DefaultName
        {
            get => "Key";
            set { }
        }
    }
}
