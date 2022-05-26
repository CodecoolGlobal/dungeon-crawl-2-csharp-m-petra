using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class SideWalk : Actor
    {
        protected override int DefaultSpriteId
        {
            get => 0;
            set => throw new System.NotImplementedException();
        }

        public override string DefaultName
        {
            get => "SideWalk";
            set { }
        }
    }
}
