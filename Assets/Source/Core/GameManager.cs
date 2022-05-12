using System.Text.RegularExpressions;
using Assets.Source.Actors.CaracterName;
using Assets.Source.Actors.Static.Items;
using UnityEngine;

namespace DungeonCrawl.Core
{
    /// <summary>
    ///     Loads the initial map and can be used for keeping some important game variables
    /// </summary>
    public class GameManager : MonoBehaviour
    {
        private void Start()
        {
            WelcomeScreen();
            //MapLoader.LoadMap(1);
        }
        private void WelcomeScreen()
        {
            ActorManager.Singleton.Spawn<A>((0, 0));
            CameraController.Singleton.Position = (0, 0);
            //LoadWelcomeTable();
            //UserInterface.Singleton.SetText("valami", UserInterface.TextPosition.MiddleCenter);

        }
        public static void LoadWelcomeTable()
        {
            var Chars = Regex.Split(Resources.Load<TextAsset>("characters").text, "\r\n|\r|\n");
            
            var heigth = 8;
            var width = 10;

            for (var y = 0; y < width; y++)
            {
                var line = Chars[y + 1];
                for (var x = 0; x < heigth; x++)
                {
                    var character = line[x];
                    SpawnTable(character, (x, -y));
                    CameraController.Singleton.Position = (x, -y);
                }
            }
        }

        private static void SpawnTable(char c, (int x, int y) position)
        {
            ActorManager.Singleton.Spawn<TableItem>(position);


        }
    }
}