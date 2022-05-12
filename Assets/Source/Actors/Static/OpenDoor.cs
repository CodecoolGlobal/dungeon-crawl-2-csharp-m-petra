using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static
{
    public class OpenDoor : Actor
    {
        protected override int DefaultSpriteId => 437;
        public override string DefaultName
        {
            get => "OpenDoor";
            set { }
        }
    }
}
