using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Source.Actors.Static.Items
{
    internal class CrossBow : Weapon
    {
        protected override int DefaultSpriteId => 278;
        public override string DefaultName
        {
            get => "Cross-bow";
            set { }
        }
    }
}
