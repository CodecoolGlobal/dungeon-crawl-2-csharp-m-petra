using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Static.Items
{
    public class TableItem : Actor
    {
        public override string DefaultName
            {
                get => "TableItem";
                set { }
            }

        public override int DefaultSpriteId => throw new NotImplementedException();


    }
}
