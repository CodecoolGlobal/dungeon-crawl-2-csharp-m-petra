using Assets.Source.Actors.Static;
using Assets.Source.Core;
using DungeonCrawl.Actors.Static;
using DungeonCrawl.Core;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace DungeonCrawl.Actors.Characters
{
    public class Player : Character
    {
        public string Name { get; set; }

        public void InitPlayer(Player player)
        {
            Inventory = player.Inventory;
            Strength = player.Strength;
            Health = player.Health;
            Name = player.Name;
            Defense = player.Defense;
        }

        //public static AudioClip stepSound;
        //public static AudioSource audioSrc;



        //[SerializeField] private AudioSource stepSoundeffect;

        public List<Item> Inventory = new List<Item>();

        protected override void OnUpdate(float deltaTime)
        {

            if (Input.GetKeyDown(KeyCode.W))
            {
                Sounds("try");

                // Move up
                TryMove(Direction.Up);
                //stepSoundeffect.Play();

            }



            if (Input.GetKeyDown(KeyCode.S))
            {
                Sounds("try");

                // Move down

                TryMove(Direction.Down);
                //    /*stepSoundeffect.Play()*/;
                //    //var audioSource = GetComponent<AudioSource>();
                //    //audioSource.Play();
                //}
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                Sounds("try");
                // Move left
                TryMove(Direction.Left);
                //stepSoundeffect.Play();
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                Sounds("try");
                // Move right
                TryMove(Direction.Right);
                //stepSoundeffect.Play();
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                Sounds("pickUp");
                var item = ActorManager.Singleton.GetActorAt<Item>(this.Position);
                if (item != null)
                {
                    UserInterface.Singleton.SetText("", UserInterface.TextPosition.BottomRight);
                    Inventory.Add(item);
                    DisplayInventory();

                    // Having a weapon increases attack strength.
                    if (item is Weapon weapon)
                    {
                        Strength += weapon.Attack;
                    }

                    if (item is Armor armor)
                    {
                        Defense += armor.Defense;
                    }

                    ActorManager.Singleton.DestroyActor(item);
                }
            }
        }

        private void DisplayInventory()
        {
            var inventoryDisplay = Inventory.Aggregate("Inventory:\n", (current, invItem) => current + $"{invItem.DefaultName}\n");
            UserInterface.Singleton.SetText(inventoryDisplay, UserInterface.TextPosition.TopLeft);
        }

        protected override bool OnCollision(Actor anotherActor)
        {
            return false;
        }

        protected override void OnDeath()
        {
            Debug.Log("Oh no, I'm dead!");
            DisplayHealth();
        }

        protected override int DefaultSpriteId => 24;
        public override string DefaultName
        {
            get => "Player";
            set { }
        }

        public void DisplayHealth()
        {
            var message = Health <= 0 ? "You died" : $"{Name} Health: {Health} ";
            UserInterface.Singleton.SetText(message, UserInterface.TextPosition.TopCenter);
        }

        public override int Health { get; set; } = 50;
        public override int Strength { get; set; } = 5;
        public override int Money { get; set; } = 0;
        public override int Defense { get; set; } = 0;
    }
}
