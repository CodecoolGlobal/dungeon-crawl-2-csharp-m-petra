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
        protected override int DefaultSpriteId
        {
            get => 228;
            set => throw new System.NotImplementedException();
        }
    }

    public class Shield2 : Armor
    {
        protected override int DefaultSpriteId
        {
            get => 230;
            set => throw new System.NotImplementedException();
        }

        public override string DefaultName
        {
            get => "Invincible";
            set { }
        }
    }

    public class Shield3 : Armor
    {
        protected override int DefaultSpriteId
        {
            get => 231;
            set => throw new System.NotImplementedException();
        }

        public override string DefaultName
        {
            get => "Stonewall";
            set { }
        }
    }
}
