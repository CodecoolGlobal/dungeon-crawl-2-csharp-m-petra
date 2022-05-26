using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Source.Actors.Static
{
    internal class Scroll : Item
    {
        protected override int DefaultSpriteId
        {
            get => 752;
            set => throw new NotImplementedException();
        }

        public override string DefaultName
        {
            get => "Scroll";
            set { }
        }
    }
}
