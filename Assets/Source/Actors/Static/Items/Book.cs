using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Source.Actors.Static.Items
{
    internal class Book : Item
    {
        protected override int Z => -1;
        protected override int DefaultSpriteId => 284;
        public override string DefaultName
        {
            get => "Book";
            set { }
        }
    }
}
