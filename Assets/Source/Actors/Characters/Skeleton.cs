using System;
using UnityEngine;

namespace DungeonCrawl.Actors.Characters
{
    public class Skeleton : Character
    {
        protected override int DefaultSpriteId
        {
            get => 316;
            set => throw new NotImplementedException();
        }

        public override string DefaultName
        {
            get => "Skeleton";
            set { }
        }
        public override int Health { get; set; } = 20;
        public override int Strength { get; set; } = 2;
        public override int Money { get; set; }

        protected override bool OnCollision(Actor anotherActor)
        {
            if (!(anotherActor is Player player)) return false;
            Fight(player);

            return true;
        }

        protected override void OnUpdate(float deltaTime)
        {
            //TODO get Player position
            //TODO make an object go to a certain position
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

        private void Update()
        {
            if (Time.time > nextActionTime)
            {
                nextActionTime = Time.time + period;
                OnUpdate(Time.deltaTime);
            }
        }

        private float nextActionTime = 0.0f;
        private float period = 0.7f;
    }
}
