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
        public int GateCount = 0;
        public List<Item> Inventory = new List<Item>();

        protected override void OnUpdate(float deltaTime)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                // Move up
                TryMove(Direction.Up);
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                // Move down
                TryMove(Direction.Down);
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                // Move left
                TryMove(Direction.Left);
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                // Move right
                TryMove(Direction.Right);
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                var item = ActorManager.Singleton.GetActorAt<Item>(this.Position);
                if (item != null)
                {
                    UserInterface.Singleton.SetText("", UserInterface.TextPosition.BottomRight);

                    Inventory.Add(item);

                    DisplayInventory();

                    // Having a weapon increases attack strength.
                    if (item is Sword sword)
                    {
                        Strength += sword.Attack;
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

        public override bool OnCollision(Actor anotherActor)
        {
            return false;
        }

        protected override void OnDeath()
        {
            Debug.Log("Oh no, I'm dead!");
        }

        public override int DefaultSpriteId => 24;
        public override string DefaultName
        {
            get => "Player";
            set { }
        }

        public override int Health { get; set; } = 50;
        public override int Strength { get; set; } = 5;

    }
}
