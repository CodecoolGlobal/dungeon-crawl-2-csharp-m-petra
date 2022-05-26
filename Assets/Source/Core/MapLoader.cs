using Assets.Source.Actors.Static;
using Assets.Source.Core;
using DungeonCrawl.Actors;
using DungeonCrawl.Actors.Characters;
using DungeonCrawl.Actors.Static;
using System;
using System.Text.RegularExpressions;
using Assets.Source.Actors.Static.Items;
using UnityEngine;

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
        public static void LoadMap(int id, Player oldPlayer = null, string name = null)
        {
            var lines = Regex.Split(Resources.Load<TextAsset>($"map_{id}").text, "\r\n|\r|\n");

            // Read map size from the first line
            var split = lines[0].Split(' ');
            var width = int.Parse(split[0]);
            var height = int.Parse(split[1]);
            // Create actors
            Player player = null;
            for (var y = 0; y < height; y++)
            {
                var line = lines[y + 1];
                for (var x = 0; x < width; x++)
                {
                    var character = line[x];
                    if (character == 'p')
                    {
                        if (oldPlayer == null)
                        {
                            player = ActorManager.Singleton.Spawn<Player>((x, -y));
                            player.Name = name;
                            CameraController.Singleton.Position = (x, -y);
                            //UserInterface.Singleton.SetText("Inventory:", UserInterface.TextPosition.TopLeft);
                            player.DisplayHealth();
                            UserInterface.Singleton.SetText($"Money: {player.Money} $", UserInterface.TextPosition.BottomCenter);
                        }
                        else
                        {
                            if (id == 1)
                            {
                                player = ActorManager.Singleton.Spawn<Player>((20, -18));
                                CameraController.Singleton.Position = (20, -18);
                            }
                            else
                            {
                                player = ActorManager.Singleton.Spawn<Player>((x, -y));
                                CameraController.Singleton.Position = (x, -y);
                            }

                            player.InitPlayer(oldPlayer);
                            player.ChangeOutfit();
                            ActorManager.Singleton.DestroyActor(oldPlayer);
                        }
                        CameraController.Singleton.Size = 10;
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
        }

        private static void SpawnActor(char c, (int x, int y) position, Player player)
        {
            switch (c)
            {
                case '0':
                    ActorManager.Singleton.Spawn<CrossBow>(position);
                    ActorManager.Singleton.Spawn<Floor>(position);
                    break;
                case '7':
                    ActorManager.Singleton.Spawn<Book>(position);
                    ActorManager.Singleton.Spawn<Floor>(position);
                    break;
                case '8':
                    ActorManager.Singleton.Spawn<Scroll>(position);
                    ActorManager.Singleton.Spawn<Floor>(position);
                    break;
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
                    ActorManager.Singleton.Spawn<FenceHor>(position);
                    break;
                case '4':
                    ActorManager.Singleton.Spawn<SideWalk2>(position);
                    break;
                case '5':
                    ActorManager.Singleton.Spawn<ShelterHouse>(position);
                    break;
                case 'y':
                    ActorManager.Singleton.Spawn<SideWalk>(position);
                    ActorManager.Singleton.Spawn<Money>(position);
                    break;
                case '?':
                    ActorManager.Singleton.Spawn<Floor>(position);
                    ActorManager.Singleton.Spawn<Heart>(position);
                    break;
                case '6':
                    ActorManager.Singleton.Spawn<Building>(position);
                    break;
                case 'C':
                    ActorManager.Singleton.Spawn<Cat>(position);
                    break;
                case 'B':
                    ActorManager.Singleton.Spawn<Trap>(position);
                    
                    break;
                case 'V':
                    ActorManager.Singleton.Spawn<Rail>(position);
                    break;
                case 'R':
                    ActorManager.Singleton.Spawn<Red>(position);
                    break;
                case 'O':
                    ActorManager.Singleton.Spawn<Car>(position);
                    break;
                case ' ':
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private static char ReverseSwitch(Actor actor) =>
            actor is null
                ? ' '
                : actor.DefaultName switch
                {
                    "Player" => 'p',
                    "Wall" => '#',
                    "Floor" => '.',
                    "Skeleton" => 's',
                    "Monster" => 'm',
                    "Key" => 'k',
                    "Sword" => 'S',
                    "Ghost" => 'g',
                    "Grass" => ',',
                    "Forest" => 'f',
                    "Stone" => 'o',
                    "CloseDoor" => 'a',
                    "River" => 'r',
                    "Bush" => 'b',
                    "Bridge" => 'u',
                    "House" => 'h',
                    "Stair" => 'd',
                    _ => '?'
                };

        public static void DrawInFile(int id)
        {
            var width = 0;
            var height = 0;
            if (id == 3)
            {
                width = 25;
                height = 20;
            }
            else
            {
                width = 113;
                height = 20;
            }
            var Map = $"{width} {height}\n";
            for (var y = 0; y < height; y++)
            {
                for (var x = 0; x < width; x++)
                {
                    Map += $"{ReverseSwitch(ActorManager.Singleton.GetActorForDrawMap((x, -y)))}";

                }
                Map += "\n";
            }
            // File.WriteAllText(@$"C:\Users\kissb\Desktop\Codecool_OOP\dungeon-crawl-1-csharp-Elmaz-Doszaki\Assets\Resources\map_{id}.txt", Map);
        }
    }
}
