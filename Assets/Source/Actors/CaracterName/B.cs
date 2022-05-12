using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawl.Actors;

namespace Assets.Source.Actors.CaracterName
{
    public class B : Actor
    {
        public override string DefaultName
        {
            get => "B";
            set { }
        }

        public override int DefaultSpriteId => 899;
    }
}
