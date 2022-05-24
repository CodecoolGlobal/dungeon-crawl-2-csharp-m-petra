namespace Assets.Source.Actors.Static
{
    public abstract class Armor : Item
    {
        public virtual int Defense { get; set; } = 3;
    }

    public class Shield1 : Armor
    {
        public override string DefaultName
        {
            get => "Durex";
            set { }
        }
        protected override int DefaultSpriteId => 228;
    }

    public class Shield2 : Armor
    {
        protected override int DefaultSpriteId => 230;

        public override string DefaultName
        {
            get=>"Invincible"; 
            set{ }
        }
    }

    public class Shield3 : Armor
    {
        protected override int DefaultSpriteId => 231;
        public override string DefaultName { 
            get=>"Stonewall";
            set{ }
        }
    }
}
