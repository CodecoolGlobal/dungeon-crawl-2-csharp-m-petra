using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class OpenDoor : Actor
    {
        protected override int DefaultSpriteId
        {
            get => 437;
            set => throw new System.NotImplementedException();
        }

        public override string DefaultName
        {
            get => "OpenDoor";
            set { }
        }
    }
}
