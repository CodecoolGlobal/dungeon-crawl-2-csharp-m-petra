using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawl.Actors;
using DungeonCrawl.Actors.Characters;

namespace Assets.Source.Actors.Characters
{
    internal class Zombie : Character
    {

        /// <summary>
        ///     Id of the default sprite of this actor type
        /// </summary>
        protected override int DefaultSpriteId { get; }

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

        protected override void OnUpdate(float deltaTime)
        {

        }

    }
}
