using Assets.Source.Actors.Static;

namespace DungeonCrawl.Actors.Static
{
    public abstract class Weapon : Item
    {
    }

    public class Sword : Weapon
    {
        protected override int DefaultSpriteId => 367;
        public override string DefaultName
        {
            get => "Sword";
            set { }
        }
    }
}
