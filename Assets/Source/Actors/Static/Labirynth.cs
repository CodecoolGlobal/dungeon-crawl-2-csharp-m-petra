using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawl.Actors;
namespace Assets.Source.Actors.Static
{
    public class Labirynth : Actor
    {
        public override int DefaultSpriteId => 546;
        public override string DefaultName
        {
            get => "Labirynth";
            set { }
        }
        public override bool OnCollision(Actor anotherActor)
        {
            return true;
        }
    }

}
