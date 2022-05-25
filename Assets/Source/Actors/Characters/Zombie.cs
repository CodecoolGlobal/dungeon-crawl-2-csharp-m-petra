using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Source.Actors.Static;
using DungeonCrawl;
using DungeonCrawl.Actors;
using DungeonCrawl.Actors.Characters;

namespace Assets.Source.Actors.Characters
{
    internal class Zombie : Character
    {

        /// <summary>
        ///     Id of the default sprite of this actor type
        /// </summary>
        protected override int DefaultSpriteId { get; } = 317;

        /// <summary>
        ///     Default name assigned to this actor type
        /// </summary>
        public override string DefaultName
        {
            get => "Zombie";
            set { }
        }
        public override int Health { get; set; }
        public override int Money { get; set; }
        public override int Strength { get; set; }

        protected override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player player)
            {
                Fight(player);

                return true;
            }

            return false;
        }

        /// <summary>
        /// TODO Create gold, make pirate move around it
        /// NOW it moves around skull
        /// </summary>
        /// <param name="deltaTime"></param>
        protected override void OnUpdate(float deltaTime)
        {
            var rd = new System.Random();
            int randNum = rd.Next(1, 5);
            switch (randNum)
            {
                case 1:
                    TryMove(Direction.Up);
                    break;
                case 2:
                    TryMove(Direction.Right);
                    break;
                case 3:
                    TryMove(Direction.Left);
                    break;
                case 4:
                    TryMove(Direction.Down);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(Direction), randNum, null);
            }

        }

    }
}
