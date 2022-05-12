using Assets.Source.Actors.CaracterName;
using System;
using System.Text.RegularExpressions;
using UnityEngine;
using Cursor = Assets.Source.Actors.CaracterName.Cursor;

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
        }
        private void WelcomeScreen()
        {

            CameraController.Singleton.Position = (0, 0);
            LoadWelcomeTable();
            //UserInterface.Singleton.SetText("valami", UserInterface.TextPosition.MiddleCenter);

        }
        public static void LoadWelcomeTable()
        {
            var Chars = Regex.Split(Resources.Load<TextAsset>("characters").text, "\r\n|\r|\n");

            var heigth = 9;
            var width = 5;

            for (var y = 0; y < heigth; y++)
            {
                var line = Chars[y];
                for (var x = 0; x < width; x++)
                {
                    var character = line[x];
                    SpawnTable(character, (x, -y));
                }
            }
        }

        private static void SpawnTable(char c, (int x, int y) position)
        {
            switch (c)
            {
                case 'A':
                    ActorManager.Singleton.Spawn<Cursor>(position);
                    CameraController.Singleton.Position = (position.x, position.y);
                    ActorManager.Singleton.Spawn<A>(position);
                    break;
                case 'B':
                    ActorManager.Singleton.Spawn<B>(position);
                    break;
                case 'C':
                    ActorManager.Singleton.Spawn<C>(position);
                    break;
                case 'D':
                    ActorManager.Singleton.Spawn<D>(position);
                    break;
                case 'E':
                    ActorManager.Singleton.Spawn<E>(position);
                    break;
                case 'F':
                    ActorManager.Singleton.Spawn<F>(position);
                    break;
                case 'G':
                    ActorManager.Singleton.Spawn<G>(position);
                    break;
                case 'H':
                    ActorManager.Singleton.Spawn<H>(position);
                    break;
                case 'I':
                    ActorManager.Singleton.Spawn<I>(position);
                    break;
                case 'J':
                    ActorManager.Singleton.Spawn<J>(position);
                    break;
                case 'K':
                    ActorManager.Singleton.Spawn<K>(position);
                    break;
                case 'L':
                    ActorManager.Singleton.Spawn<L>(position);
                    break;
                case 'M':
                    ActorManager.Singleton.Spawn<M>(position);
                    break;
                case 'N':
                    ActorManager.Singleton.Spawn<N>(position);
                    break;
                case 'O':
                    ActorManager.Singleton.Spawn<O>(position);
                    break;
                case 'P':
                    ActorManager.Singleton.Spawn<P>(position);
                    break;
                case 'Q':
                    ActorManager.Singleton.Spawn<Q>(position);
                    break;
                case 'R':
                    ActorManager.Singleton.Spawn<R>(position);
                    break;
                case 'S':
                    ActorManager.Singleton.Spawn<S>(position);
                    break;
                case 'T':
                    ActorManager.Singleton.Spawn<T>(position);
                    break;
                case 'U':
                    ActorManager.Singleton.Spawn<U>(position);
                    break;
                case 'Z':
                    ActorManager.Singleton.Spawn<Z>(position);
                    break;
                case 'V':
                    ActorManager.Singleton.Spawn<V>(position);
                    break;
                case 'W':
                    ActorManager.Singleton.Spawn<W>(position);
                    break;
                case '1':
                    ActorManager.Singleton.Spawn<One>(position);
                    break;
                case '2':
                    ActorManager.Singleton.Spawn<Two>(position);
                    break;
                case '3':
                    ActorManager.Singleton.Spawn<Three>(position);
                    break;
                case '4':
                    ActorManager.Singleton.Spawn<Four>(position);
                    break;
                case '5':
                    ActorManager.Singleton.Spawn<Five>(position);
                    break;
                case '6':
                    ActorManager.Singleton.Spawn<Six>(position);
                    break;
                case '7':
                    ActorManager.Singleton.Spawn<Seven>(position);
                    break;
                case '8':
                    ActorManager.Singleton.Spawn<Eight>(position);
                    break;
                case '9':
                    ActorManager.Singleton.Spawn<Nine>(position);
                    break;
                case '0':
                    ActorManager.Singleton.Spawn<Zero>(position);
                    break;
                case '!':
                    ActorManager.Singleton.Spawn<Enter>(position);
                    break;
                case '<':
                    ActorManager.Singleton.Spawn<BackSpace>(position);
                    break;
                case '-':
                    ActorManager.Singleton.Spawn<Hyphen>(position);
                    break;
                case ' ':
                    ActorManager.Singleton.Spawn<Empty>(position);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}