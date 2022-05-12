using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawl.Actors;

namespace Assets.Source.Actors.CaracterName
{
    public class A : Actor
    {
        public override string DefaultName
        {
            get => "A";
            set { }
        }

        public override int DefaultSpriteId => 898;
    }
}
