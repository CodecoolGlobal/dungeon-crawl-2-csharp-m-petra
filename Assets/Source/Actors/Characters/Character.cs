using Assets.Source.Core;
using DungeonCrawl.Core;
using System;
using System.Threading.Tasks;

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

                ApplyDamage(player.Strength);

                player.DisplayHealth(false);

                if (this.Health <= 0)
                {
                    UserInterface.Singleton.SetText($" You have defeated a {DefaultName}", UserInterface.TextPosition.TopRight);
                    DeleteDisplay();

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

        public async void DeleteDisplay()
        {

            await Task.Delay(TimeSpan.FromSeconds(2));
            UserInterface.Singleton.SetText("", UserInterface.TextPosition.TopRight);
        }

    }

}

