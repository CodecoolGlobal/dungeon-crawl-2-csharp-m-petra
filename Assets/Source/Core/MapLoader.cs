using DungeonCrawl.Actors.Characters;
using DungeonCrawl.Actors.Static;
using System;
using System.Text.RegularExpressions;
using Assets.Source.Core;
using UnityEngine;
using Assets.Source.Actors.Static;

namespace DungeonCrawl.Core
{
    /// <summary>
    ///     MapLoader is used for constructing maps from txt files
    /// </summary>
    public static class MapLoader
    {
        /// <summary>
        ///     Constructs map from txt file and spawns actors at appropriate positions
        /// </summary>
        /// <param name="id"></param>
        public static void LoadMap(int id)
        {
            var lines = Regex.Split(Resources.Load<TextAsset>($"map_{id}").text, "\r\n|\r|\n");

            // Read map size from the first line
            var split = lines[0].Split(' ');
            var width = int.Parse(split[0]);
            var height = int.Parse(split[1]);

            Player player = null;
            // Create actors
            for (var y = 0; y < height; y++)
            {
                var line = lines[y + 1];
                for (var x = 0; x < width; x++)
                {
                    var character = line[x];

                    if (character == 'p')
                    {

                        player = ActorManager.Singleton.Spawn<Player>((x, -y));
                        CameraController.Singleton.Size = 10;
                        CameraController.Singleton.Position = (x, -y+1);
                        ActorManager.Singleton.Spawn<Floor>((x, -y));
                    }
                }
            }

            // Create actors
            for (var y = 0; y < height; y++)
            {
                var line = lines[y + 1];
                for (var x = 0; x < width; x++)
                {
                    var character = line[x];

                    SpawnActor(character, (x, -y), player);
                }
            }
            UserInterface.Singleton.SetText("Inventory:", UserInterface.TextPosition.TopLeft);
        }

        private static void SpawnActor(char c, (int x, int y) position, Player player)
        {
            switch (c)
            {
                case '#':
                    ActorManager.Singleton.Spawn<RedWall>(position);
                    break;
                case 'H':
                    ActorManager.Singleton.Spawn<Wall>(position);
                    break;
                case 'p':
                    break;
                case '.':
                    ActorManager.Singleton.Spawn<Tile>(position);
                    break;
                case '-':
                    ActorManager.Singleton.Spawn<Floor>(position);
                    break;
                case 's':
                    ActorManager.Singleton.Spawn<Skeleton>(position);
                    ActorManager.Singleton.Spawn<Floor>(position);
                    break;
                case 'm':
                    ActorManager.Singleton.Spawn<Monster>(position);
                    ActorManager.Singleton.Spawn<Floor>(position);
                    break;
                case 'k':
                    ActorManager.Singleton.Spawn<Key>(position);
                    ActorManager.Singleton.Spawn<Floor>(position);
                    break;
                case 'S':
                    ActorManager.Singleton.Spawn<Sword>(position);
                    ActorManager.Singleton.Spawn<Floor>(position);
                    break;
                case 'g':

                    var ghost = ActorManager.Singleton.Spawn<Ghost>(position);
                    ghost.Player = player;
                    ActorManager.Singleton.Spawn<Floor>(position);
                    break;
                case ',':
                    ActorManager.Singleton.Spawn<Grass>(position);
                    break;
                case 'f':
                    ActorManager.Singleton.Spawn<Forest>(position);
                    break;
                case 'o':
                    ActorManager.Singleton.Spawn<Stone>(position);
                    break;
                case 'a':
                    ActorManager.Singleton.Spawn<CloseDoor>(position);
                    break;
                case 'r':
                    ActorManager.Singleton.Spawn<River>(position);
                    break;
                case 'b':
                    ActorManager.Singleton.Spawn<Bush>(position);
                    break;
                case 'u':
                 
                    ActorManager.Singleton.Spawn<Bridge>(position);
                    
                    break;
                case 'h':
                    ActorManager.Singleton.Spawn<House>(position);
                    break;
                case 'd':
                    ActorManager.Singleton.Spawn<Stair>(position);
                    break;
                case 'v':
                    ActorManager.Singleton.Spawn<FenceHor>(position);
                    break;
                case 'z':
                    ActorManager.Singleton.Spawn<FenceVer>(position);
                    break;
                case 'i':
                    ActorManager.Singleton.Spawn<SideWalk>(position);
                    break;
                case 'c':
                    ActorManager.Singleton.Spawn<Cactus>(position);
                    break;
                case 't':
                    ActorManager.Singleton.Spawn<Twig>(position);
                    break;
                case 'q':
                    ActorManager.Singleton.Spawn<Skull>(position);
                    break;
                case 'n':
                    ActorManager.Singleton.Spawn<Cemetery>(position);
                    break;
                case '1':
                    ActorManager.Singleton.Spawn<Spider>(position);
                    break;
                case '2':
                    ActorManager.Singleton.Spawn<Web>(position);
                    break;
                case 'T':
                    break;
                case '4':
                    ActorManager.Singleton.Spawn<SideWalk2>(position);
                    break;
                case ' ':
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
