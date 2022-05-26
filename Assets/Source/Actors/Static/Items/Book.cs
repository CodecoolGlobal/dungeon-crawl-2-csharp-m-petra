namespace Assets.Source.Actors.Static
{
    internal class Book : Item
    {
        protected override int DefaultSpriteId => 284;
        public override string DefaultName
        {
            get => "Book";
            set { }
        }
    }
}