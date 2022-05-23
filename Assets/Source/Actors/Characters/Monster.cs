using UnityEngine;

namespace DungeonCrawl.Actors.Characters
{
    internal class Monster : Character
    {
        protected override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player player)
            {
                Fight(player);
                return true;
            }
            return false;
        }

        protected override int DefaultSpriteId => 317;
        public override string DefaultName
        {
            get => "Monster";
            set { }
        }
        public override int Health { get; set; } = 30;
        public override int Strength { get; set; } = 3;
        public override int Money { get; set; }
    }
}
