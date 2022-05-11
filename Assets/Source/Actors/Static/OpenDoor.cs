using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawl.Actors;
namespace Assets.Source.Actors.Static
{
    public class OpenDoor : Actor
    {
        public override int DefaultSpriteId => 437;
        public override string DefaultName => "OpenDoor";
        public override bool OnCollision(Actor anotherActor)
        {
            return true;
        }
    }
}
