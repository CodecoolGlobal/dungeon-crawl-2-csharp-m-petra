using Assets.Source.Core;
using DungeonCrawl.Core;
using System;
using System.Threading.Tasks;
using DungeonCrawl.Actors.Static;
using UnityEngine;

namespace DungeonCrawl.Actors.Characters
{
    public abstract class Character : Actor
    {
        public abstract int Health { get; set; }
        public abstract int Money { get; set; }
        public abstract int Strength { get; set; }

        private void ApplyDamage(int damage)
        {
            Sounds("walk");
            Health -= damage;

            if (Health <= 0)
            {
                // Die
                OnDeath();

                ActorManager.Singleton.DestroyActor(this);
            }
        }

        protected void Fight(Player player)
        {
            while (player.Health > 0)
            {

                ApplyDamage(player.Strength);

                player.DisplayHealth();

                if (this.Health <= 0)
                {
                    UserInterface.Singleton.SetText($" You have defeated a {DefaultName}", UserInterface.TextPosition.TopRight);
                    DeleteDisplay();

                    break;
                }
                player.ApplyDamage(this.Strength);
            }
        }

        protected virtual void OnDeath()
        {
            Sounds("door");
            Debug.Log($"Well, I was a {DefaultName}...");
            ItemDrop();
        }

        private void ItemDrop()
        {
            var random = new System.Random();
            var x = random.Next(0, 5);
            switch (x)
            {
                case 0:
                    ActorManager.Singleton.Spawn<Sword>(Position);
                    break;

            }
        }

        /// <summary>
        ///     All characters are drawn "above" floor etc
        /// </summary>
        protected override int Z => -1;

        private async void DeleteDisplay()
        {
            await Task.Delay(TimeSpan.FromSeconds(2));
            UserInterface.Singleton.SetText("", UserInterface.TextPosition.TopRight);
        }
    }
}
