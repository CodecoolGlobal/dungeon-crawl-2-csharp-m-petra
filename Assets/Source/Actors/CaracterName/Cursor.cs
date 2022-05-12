using Assets.Source.Core;
using DungeonCrawl;
using DungeonCrawl.Actors.Characters;
using DungeonCrawl.Core;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Source.Actors.CaracterName
{
    public class Cursor : Player
    {
        public override int DefaultSpriteId => 613;
        public List<string> Name = new List<string>();

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

            if (Input.GetKeyDown(KeyCode.Return))
            {
                // Select with Enter
                var item = ActorManager.Singleton.GetActorAt<Char>(this.Position).DefaultName;

                if (item == "<")
                {
                    Name.RemoveAt(Name.Count - 1);
                }
                else if (item == "!")
                {
                    var name = String.Join("", Name.ToArray());
                    ActorManager.Singleton.DestroyAllActors();
                    ActorManager.Singleton.DestroyActor(this);
                    MapLoader.LoadMap(1, null, name);
                }
                else
                {
                    Name.Add(item);
                }

                UserInterface.Singleton.SetText($"Name:{String.Join("", Name.ToArray())}", UserInterface.TextPosition.BottomLeft);
            }
        }
    }
}
