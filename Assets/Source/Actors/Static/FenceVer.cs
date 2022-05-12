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
                UserInterface.Singleton.SetText("After a nuclear explosion, \n" +
                                                " much of civilization was completely extinct. \n" +
                                                " However, a couple of people survived \n" +
                                                " and now live in the oasis. \n " +
                                                "If you want to survive too, you have to find \n " +
                                                "the key and use it to get into the oasis. \n" +
                                                "You will then be sheltered in the red house.", UserInterface.TextPosition.MiddleLeft);
            }
            return true;
        }
    }
}
