using Assets.Source.Core;
using DungeonCrawl.Actors;
using DungeonCrawl.Actors.Characters;

namespace Assets.Source.Actors.Static
{
    public class FenceVer : Actor
    {
        public override int DefaultSpriteId => 753;
        public override string DefaultName
        {
            get => "FenceVer";
            set { }
        }
        public override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player)
            {
                UserInterface.Singleton.SetText("BLABLbLABLABLABLA \n blablablabla", UserInterface.TextPosition.MiddleLeft);
            }
            return true;
        }
    }
}
