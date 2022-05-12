using DungeonCrawl.Core;

namespace DungeonCrawl.Actors.Characters
{
    public abstract class Character : Actor
    {
        public abstract int Health { get; set; }

        public abstract int Strength { get; set; }
        public void ApplyDamage(int damage)
        {
            Health -= damage;

            if (Health <= 0)
            {
                // Die
                OnDeath();

                ActorManager.Singleton.DestroyActor(this);
            }
        }

        public void Figth(Player player)
        {
            while (player.Health > 0)
            {
                player.DisplayHealth(false);
                ApplyDamage(player.Strength);
                if (this.Health <= 0)
                {
                    break;
                }
                player.ApplyDamage(this.Strength);
                
            }
        }

        protected abstract void OnDeath();

        /// <summary>
        ///     All characters are drawn "above" floor etc
        /// </summary>
        public override int Z => -1;
    }
}
