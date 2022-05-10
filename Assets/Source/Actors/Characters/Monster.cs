using UnityEngine;

namespace DungeonCrawl.Actors.Characters
{
    internal class Monster : Character
    {
        public override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player player)
            {
                Figth(player);

                return true;
            }

            return false;
        }

        protected override void OnDeath()
        {
            Debug.Log("Well, I am monster...");
        }

        public override int DefaultSpriteId => 317;
        public override string DefaultName => "Monster";

        public override int Health { get; set; } = 30;
        public override int Strength { get; set; } = 3;
    }
}
