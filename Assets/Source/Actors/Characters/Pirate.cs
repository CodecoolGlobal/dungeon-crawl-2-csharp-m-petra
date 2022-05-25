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
    public class Pirate : Character
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
            get => "Pirate";
            set { }
        }
        public override int Health { get; set; }
        public override int Money { get; set; }
        public override int Strength { get; set; }

        /// <summary>
        /// I want to move around this
        /// </summary>
        public Skull Skull { get; set; }


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
            if (Skull.Position.x < Position.x)
                TryMove(Direction.Up);

            if (Skull.Position.x > Position.x)
                TryMove(Direction.Down);

            if (Skull.Position.y > Position.y)
                TryMove(Direction.Right);

            if (Skull.Position.y < Position.y)
                TryMove(Direction.Left);
        }
    }
}
