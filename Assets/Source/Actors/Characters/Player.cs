
﻿using System.Collections.Generic;
 using Assets.Source.Actors.Static;
 using Assets.Source.Core;
 using DungeonCrawl.Actors.Static;
using UnityEditor.PackageManager;
using UnityEditorInternal;
﻿using DungeonCrawl.Core;
using UnityEngine;

namespace DungeonCrawl.Actors.Characters
{
    public class Player : Character
    {
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

                    // Having a weapon increases attack strength.
                    if (item is Sword sword)
                    {
                        Strength += sword.Attack;
                    }

                    ActorManager.Singleton.DestroyActor(item);

                }
            }
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
        public override string DefaultName => "Player";

        public override int Health { get; set; } = 50;
        public override int Strength { get; set; } = 5;
    }
}
