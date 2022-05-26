using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawl.Actors;

namespace Assets.Source.Actors.Skill
{
    internal class Arrow : Actor
    {
        protected override int Z => -2;
        protected override int DefaultSpriteId
        {
            get => 279;
            set => throw new NotImplementedException();
        }

        public override string DefaultName
        {
            get => "Arrow";
            set { }
        }

        public override bool Detectable { get; set; } = false;
    }
}
