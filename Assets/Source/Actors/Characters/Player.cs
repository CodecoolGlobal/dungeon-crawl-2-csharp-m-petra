
﻿using System.Collections.Generic;
using DungeonCrawl.Actors.Static;
using UnityEditor.PackageManager;
using UnityEditorInternal;
﻿using DungeonCrawl.Core;
using UnityEngine;

namespace DungeonCrawl.Actors.Characters
{
    public class Player : Character
    {
        readonly Dictionary<string, int> _inventory = new() { { "key", 0 }, { "sword", 0 } };

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
                var key = ActorManager.Singleton.GetActorAt<Key>(this.Position);
                var sword = ActorManager.Singleton.GetActorAt<Sword>(this.Position);
                if (key != null)
                {
                    _inventory["key"] += 1;
                    ActorManager.Singleton.DestroyActor(key);
                }

                if (sword != null)
                {
                    _inventory["sword"] += 1;
                    ActorManager.Singleton.DestroyActor(sword);
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
