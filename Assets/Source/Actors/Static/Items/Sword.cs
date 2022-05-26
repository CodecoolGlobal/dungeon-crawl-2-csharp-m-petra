using Assets.Source.Actors.Static;

namespace DungeonCrawl.Actors.Static
{
    public abstract class Weapon : Item
    {
        public int Attack
        {
            get => 5;
            set => throw new System.NotImplementedException();
        }
    }

    public class Sword : Weapon
    {
        protected override int DefaultSpriteId
        {
            get => 367;
            set => throw new System.NotImplementedException();
        }

        public override string DefaultName
        {
            get => "Widow-maker";
            set { }
        }

    }

    public class Sword1 : Weapon
    {
        protected override int DefaultSpriteId
        {
            get => 464;
            set => throw new System.NotImplementedException();
        }

        public override string DefaultName
        {
            get => "Maiden-Tear";
            set { }
        }
    }

    public class Sword2 : Weapon
    {
        protected override int DefaultSpriteId
        {
            get => 465;
            set => throw new System.NotImplementedException();
        }

        public override string DefaultName
        {
            get => "Kings-bane";
            set { }
        }
    }
}
