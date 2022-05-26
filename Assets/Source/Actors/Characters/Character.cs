using Assets.Source.Core;
using DungeonCrawl.Core;
using System;
using System.Drawing;
using System.Threading.Tasks;
using Assets.Source.Actors.Static;
using DungeonCrawl.Actors.Static;
using UnityEngine;

namespace DungeonCrawl.Actors.Characters
{
    public abstract class Character : Actor
    {
        public abstract int Health { get; set; }
        public abstract int Money { get; set; }
        public abstract int Strength { get; set; }
        public int Defense { get; set; } = 0;
        public void ApplyDamage(int damage)
        {
            Sounds("walk");
            Explode();
            Health -= damage<Defense?0:damage-Defense;

            if (Health <= 0)
            {
                // Die
                OnDeath();
                
                ActorManager.Singleton.DestroyActor(this);
            }
        }

        public void Explode()
        {
            
            ParticleSystem exp = GetComponent<ParticleSystem>();
            if (exp== null) exp = gameObject.AddComponent<ParticleSystem>();
            //var shape = new ParticleSystem.ShapeModule();
            //var emission = new ParticleSystem.EmissionModule();
            //shape.radius = 0.5f;
            //emission.rate = 0;
            //emission.burstCount = 0;
            exp.Stop();
            var particle = exp.main;
            particle.duration = 0.5f;
            particle.loop = false;
            //particle.startColor = UnityEngine.Color.red;
            //particle.startColor = new ParticleSystem.MinMaxGradient(UnityEngine.Color.blue);
            particle.startSpeed = new ParticleSystem.MinMaxCurve(100, 0);

  
            exp.Play();
            
            // Destroy(gameObject, exp.main.duration);
        }

        protected void Fight(Player player)
        {
            while (player.Health > 0)
            {
                CameraController.Singleton.Position= (495, 205);
                ApplyDamage(player.Strength);

                player.DisplayHealth();

                if (this.Health <= 0)
                {
                    UserInterface.Singleton.SetText($" You have defeated a {DefaultName}", UserInterface.TextPosition.TopRight);
                    UserInterface.Singleton.DeleteDisplay(2);

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
            var x = random.Next(0, 45);
            Item item = x switch
            {
                0 => ActorManager.Singleton.Spawn<Sword>(Position),
                1 => ActorManager.Singleton.Spawn<Shield2>(Position),
                2 => ActorManager.Singleton.Spawn<Sword2>(Position),
                3 => ActorManager.Singleton.Spawn<Shield3>(Position),
                4 => ActorManager.Singleton.Spawn<Sword1>(Position),
                5 => ActorManager.Singleton.Spawn<Shield1>(Position),
                _ => null
            };

            var anotherActor = ActorManager.Singleton.GetActorAt<Player>(Position);
            if (anotherActor == null) return;
            if (item != null)
            {
                UserInterface.Singleton.SetText($"Press E to pick up {item.DefaultName}\n", UserInterface.TextPosition.BottomRight);
            }
        }

        /// <summary>
        ///     All characters are drawn "above" floor etc
        /// </summary>
        protected override int Z => -1;
    }
}
