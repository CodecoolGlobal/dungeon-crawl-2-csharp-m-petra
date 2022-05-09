using UnityEngine;

namespace DungeonCrawl.Actors.Characters
{
    public class Skeleton : Character
    {
        public override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player player)
            {
                while (player.Health > 0)
                {
                    ApplyDamage(player.Strength);
                    if (this.Health <= 0)
                    {
                        break;
                    }
                    player.ApplyDamage(this.Strength);
                }
            }

            return true;
        }

        protected override void OnDeath()
        {
            Debug.Log("Well, I was already dead anyway...");
        }

        public override int DefaultSpriteId => 316;
        public override string DefaultName => "Skeleton";

        public override int Health { get; set; } = 20;
        public override int Strength { get; set; } = 2;
    }
}
