using DungeonCrawl.Actors;
using System;
namespace Assets.Source.Actors.Static
{
    public class OpenDoor : Actor
    {
        public override int DefaultSpriteId => 437;
        public override string DefaultName
        {
            get => "OpenDoor";
            set { }
        }

        public override bool OnCollision(Actor anotherActor)
        {
            return true;
        }
    }
}
