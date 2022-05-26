namespace DungeonCrawl.Actors.Static
{
    public class Floor : Actor
    {
        protected override int DefaultSpriteId
        {
            get => 1;
            set => throw new System.NotImplementedException();
        }

        public override string DefaultName
        {
            get => "Floor";
            set { }
        }

        public override bool Detectable => false;
    }
}
