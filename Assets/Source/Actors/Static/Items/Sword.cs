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
            get => "Widow-maker";
            set { }
        }
        public int Attack => 5;
    }

    public class Sword1:Weapon
    {
        protected override int DefaultSpriteId => 464;

        public override string DefaultName
        {
            get=>"Maiden-Tear"; 
            set{ }
        }
    }

    public class Sword2 : Weapon
    {
        protected override int DefaultSpriteId => 465;
        public override string DefaultName { 
            get=>"Kings-bane";
            set{ }
        }
    }
}
