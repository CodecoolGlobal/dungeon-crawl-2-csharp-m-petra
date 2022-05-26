using Assets.Source.Actors.Skill;
using Assets.Source.Actors.Static;
using Assets.Source.Core;
using DungeonCrawl.Actors.Static;
using DungeonCrawl.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        
        public List<Item> Inventory = new List<Item>();

       
        protected override void OnUpdate(float deltaTime)
        {

            if (Input.GetKeyDown(KeyCode.W))
            {
                Sounds("try");
                // Move up
                TryMove(Direction.Up);
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                Sounds("try");
                // Move down
                TryMove(Direction.Down);
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                Sounds("try");
                // Move left
                TryMove(Direction.Left);
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                Sounds("try");
                // Move right
                TryMove(Direction.Right);
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                Sounds("pickUp");
                var item = ActorManager.Singleton.GetActorAt<Item>(this.Position);
                if (item != null)
                {
                    UserInterface.Singleton.SetText("", UserInterface.TextPosition.BottomRight);
                    Inventory.Add(item);

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

            if (Input.GetKeyDown(KeyCode.I))
            {
                DisplayInventory();
            }

            if (Input.GetKeyDown(KeyCode.UpArrow) && (Input.GetKeyDown(KeyCode.RightArrow)) && Inventory.Any(x => x is Weapon))
            {
                // Strike upright
                SwordStrike(Direction.UpRight);
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow) && (Input.GetKeyDown(KeyCode.LeftArrow)) && Inventory.Any(x => x is Weapon))
            {
                // Strike upleft
                SwordStrike(Direction.UpLeft);
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow) && (Input.GetKeyDown(KeyCode.LeftArrow)) && Inventory.Any(x => x is Weapon))
            {
                // Strike downleft
                SwordStrike(Direction.DownLeft);
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow) && (Input.GetKeyDown(KeyCode.RightArrow)) && Inventory.Any(x => x is Weapon))
            {
                // Strike downright
                SwordStrike(Direction.DownRight);
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow) && Inventory.Any(x => x is Weapon))
            {
                // Strike up
                SwordStrike(Direction.Up);
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow) && Inventory.Any(x => x is Weapon))
            {
                // Strike down
                SwordStrike(Direction.Down);
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && Inventory.Any(x => x is Weapon))
            {
                // Strike left
                SwordStrike(Direction.Left);
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && Inventory.Any(x => x is Weapon))
            {
                // Strike right
                SwordStrike(Direction.Right);
            }
        }

        private void SwordStrike(Direction direction)
        {
            var targetPosition = TargetPosition(direction);

            var swordStrike = ActorManager.Singleton.Spawn<SwordStrike>(targetPosition);
            swordStrike.transform.eulerAngles = direction switch
            {
                Direction.Up => Vector3.forward * 45,
                Direction.Down => Vector3.forward * 225,
                Direction.Left => Vector3.forward * 135,
                Direction.Right => Vector3.forward * 315,
                Direction.UpRight => Vector3.forward * 1,
                Direction.UpLeft => Vector3.forward * 90,
                Direction.DownLeft => Vector3.forward * 180,
                Direction.DownRight => Vector3.forward * 260,
                _ => swordStrike.transform.eulerAngles
            };

            var damage = 50;

            AttackTarget(targetPosition, damage);

            DeleteStrike(0.2, swordStrike);
        }

        private void AttackTarget((int x, int y) targetPosition, int damage)
        {
            var actorAtTargetPosition = ActorManager.Singleton.GetActorAt(targetPosition);
            if (actorAtTargetPosition is Character character)
            {
                character.ApplyDamage(damage);
            }
        }

        private (int x, int y) TargetPosition(Direction direction)
        {
            var vector = direction.ToVector();
            (int x, int y) targetPosition = (Position.x + vector.x, Position.y + vector.y);
            return targetPosition;
        }

        private async void DeleteStrike(double time, Actor actor)
        {
            await Task.Delay(TimeSpan.FromSeconds(time));
            ActorManager.Singleton.DestroyActor(actor);
        }

        private void DisplayInventory()
        {
            if (_IsTrue)
            {
                var inventoryDisplay = Inventory.Aggregate("Inventory:\n", (current, invItem) => current + $"{invItem.DefaultName}\n");
                UserInterface.Singleton.SetText(inventoryDisplay, UserInterface.TextPosition.TopLeft);
                _IsTrue = false;
            }
            else
            {
                UserInterface.Singleton.SetText("", UserInterface.TextPosition.TopLeft);
                _IsTrue = true;
            }
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
        public bool _IsTrue = true;
    }
}
