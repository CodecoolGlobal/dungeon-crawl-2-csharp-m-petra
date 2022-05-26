namespace Assets.Source.Actors.Static
{
    internal class Book : Item
    {
        protected override int DefaultSpriteId
        {
            get => 284;
            set => throw new System.NotImplementedException();
        }

        public override string DefaultName
        {
            get => "Book";
            set { }
        }
    }
}