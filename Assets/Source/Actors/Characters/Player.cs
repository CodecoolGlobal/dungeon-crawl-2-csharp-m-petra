using Assets.Source.Actors.Skill;
using Assets.Source.Actors.Static;
using Assets.Source.Core;
using DungeonCrawl.Actors.Static;
using DungeonCrawl.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assets.Source.Actors.Static.Items;
using UnityEngine;
using Weapon = DungeonCrawl.Actors.Static.Weapon;

namespace DungeonCrawl.Actors.Characters
{
    public class Player : Character
    {
        public string Name { get; set; }

        private Item SkillItem { get; set; }

        public void InitPlayer(Player player)
        {
            Inventory = player.Inventory;
            Strength = player.Strength;
            Health = player.Health;
            Name = player.Name;
            Defense = player.Defense;
            SkillItem = player.SkillItem;
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

                    if (item is Book || item is Scroll)
                    {
                        SwitchSkillItem(item);
                        return;
                    }

                    Inventory.Add(item);

                    // Having a weapon increases attack strength.
                    if (item is Weapon weapon)
                    {
                        Strength += weapon.Attack;
                        ChangeOutfit();
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

            if (Input.GetKeyDown(KeyCode.UpArrow) && Input.GetKeyDown(KeyCode.RightArrow))
            {
                // Strike upright
                UseClassSkill(Direction.UpRight);
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow) && Input.GetKeyDown(KeyCode.LeftArrow))
            {
                // Strike upleft
                UseClassSkill(Direction.UpLeft);
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow) && Input.GetKeyDown(KeyCode.LeftArrow))
            {
                // Strike downleft
                UseClassSkill(Direction.DownLeft);
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow) && Input.GetKeyDown(KeyCode.RightArrow))
            {
                // Strike downright
                UseClassSkill(Direction.DownRight);
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                // Strike up
                UseClassSkill(Direction.Up);
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                // Strike down
                UseClassSkill(Direction.Down);
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                // Strike left
                UseClassSkill(Direction.Left);
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                // Strike right
                UseClassSkill(Direction.Right);
            }
        }

        private void UseClassSkill(Direction direction)
        {
            switch (SkillItem?.DefaultName)
            {
                case "Scroll" when Inventory.Any(x => x is Sword):
                    SwordStrike(direction);
                    break;
                case "Book" when Inventory.Any(x => x is CrossBow):
                    ShootArrow(direction);
                    break;
            }
        }

        private void ShootArrow(Direction direction)
        {
            var targetPosition = TargetPosition(direction);
            var crossBow = ActorManager.Singleton.Spawn<CrossBow>(targetPosition);

            crossBow.transform.eulerAngles = direction switch
            {
                Direction.Up => Vector3.forward * 90,
                Direction.Down => Vector3.forward * 270,
                Direction.Left => Vector3.forward * 180,
                Direction.Right => Vector3.forward * 1,
                Direction.UpRight => Vector3.forward * 45,
                Direction.UpLeft => Vector3.forward * 135,
                Direction.DownLeft => Vector3.forward * 225,
                Direction.DownRight => Vector3.forward * 315,
                _ => crossBow.transform.eulerAngles
            };

            DeleteSprite(0.5, crossBow);

            FlyingArrows(direction, targetPosition);
        }

        private async void FlyingArrows(Direction direction, (int x, int y) position)
        {
            var range = 4;
            var time = 0.0;
            for (int i = 0; i < range; i++)
            {
                await Task.Delay(TimeSpan.FromSeconds(time));
                position = FlyingArrow(direction, position);
                time += 0.08;
            }
        }

        private (int x, int y) FlyingArrow(Direction direction, (int x, int y) position)
        {
            var targetPosition = TargetPosition(direction, position);

            var arrow = ActorManager.Singleton.Spawn<Arrow>(targetPosition);
            arrow.transform.eulerAngles = direction switch
            {
                Direction.Up => Vector3.forward * 45,
                Direction.Down => Vector3.forward * 225,
                Direction.Left => Vector3.forward * 135,
                Direction.Right => Vector3.forward * 315,
                Direction.UpRight => Vector3.forward * 1,
                Direction.UpLeft => Vector3.forward * 90,
                Direction.DownLeft => Vector3.forward * 180,
                Direction.DownRight => Vector3.forward * 270,
                _ => arrow.transform.eulerAngles
            };

            var damage = 50;

            AttackTarget(targetPosition, damage);

            DeleteSprite(0.12, arrow);

            return targetPosition;
        }

        private void SwitchSkillItem(Item item)
        {
            if (SkillItem?.DefaultName != null)
            {
                if (SkillItem.DefaultName == "Book")
                {
                    ActorManager.Singleton.Spawn<Book>(Position);
                }
                else
                {
                    ActorManager.Singleton.Spawn<Scroll>(Position);
                }
            }
            
            SkillItem = item;
            ChangeOutfit();
            ActorManager.Singleton.DestroyActor(item);
        }

        public void ChangeOutfit()
        {
            if (SkillItem.DefaultName == "Book" && Inventory.Any(x => x is CrossBow))
            {
                if (DefaultSpriteId != 75)
                {
                    var newPlayer = ActorManager.Singleton.Spawn<Ranger>(Position);
                    newPlayer.InitPlayer(this);
                    ActorManager.Singleton.DestroyActor(this);
                }
            }
            else if (SkillItem.DefaultName == "Scroll" && Inventory.Any(x => x is Sword))
            {
                if (DefaultSpriteId != 27)
                {
                    var newPlayer = ActorManager.Singleton.Spawn<Warrior>(Position);
                    newPlayer.InitPlayer(this);
                    ActorManager.Singleton.DestroyActor(this);
                }
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
                Direction.DownRight => Vector3.forward * 270,
                _ => swordStrike.transform.eulerAngles
            };

            var damage = 50;

            AttackTarget(targetPosition, damage);

            DeleteSprite(0.2, swordStrike);
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

        private (int x, int y) TargetPosition(Direction direction, (int x, int y) position)
        {
            var vector = direction.ToVector();
            (int x, int y) targetPosition = (position.x + vector.x, position.y + vector.y);
            return targetPosition;
        }

        private async void DeleteSprite(double time, Actor actor)
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

        protected override int DefaultSpriteId
        {
            get => 24;
            set { }
        }

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
        protected override int Z => -2;
    }

    internal class Warrior : Player
    {
        protected override int DefaultSpriteId { get; set; } = 27;
    }

    public class Ranger : Player
    {
        protected override int DefaultSpriteId { get; set; } = 75;
    }
}
