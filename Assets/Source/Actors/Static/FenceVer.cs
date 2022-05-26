using Assets.Source.Core;
using DungeonCrawl.Actors;
using DungeonCrawl.Actors.Characters;

namespace Assets.Source.Actors.Static
{
    public class FenceVer : Actor
    {
        protected override int DefaultSpriteId
        {
            get => 753;
            set => throw new System.NotImplementedException();
        }

        public override string DefaultName
        {
            get => "FenceVer";
            set { }
        }

        protected override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player)
            {
                var message = "After a nuclear explosion, \n" +
                              " a large part of our civilization has gone\n completely extinct. \n" +
                              " However, a couple of people survived \n" +
                              " and now live in the oasis. \n " +
                              "If you want to survive as well, you have to find \n " +
                              "the key and use it to get into the oasis. \n" +
                              "After that, you need to collect 100$ and \n " +
                              "You will be sheltered in the red house.";
                UserInterface.Singleton.SetText(message, UserInterface.TextPosition.MiddleLeft);
            }
            return true;
        }
    }
}
