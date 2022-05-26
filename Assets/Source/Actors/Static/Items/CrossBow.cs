using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawl.Actors.Static;

namespace Assets.Source.Actors.Static.Items
{
    internal class CrossBow : Weapon
    {
        protected override int DefaultSpriteId
        {
            get => 278;
            set => throw new NotImplementedException();
        }

        public override string DefaultName
        {
            get => "Cross-bow";
            set { }
        }
    }
}
