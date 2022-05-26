using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Source.Actors.Static.Items
{
    internal class Scroll : Item
    {
        protected override int Z => -1;
        protected override int DefaultSpriteId => 752;
        public override string DefaultName
        {
            get => "Scroll";
            set { }
        }
    }
}
