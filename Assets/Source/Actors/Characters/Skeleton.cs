using System;
using UnityEngine;


namespace DungeonCrawl.Actors.Characters
{
    public class Skeleton : Character
    {
        public override int DefaultSpriteId => 316;
        public override string DefaultName
        {
            get => "Skeleton";
            set { }
        }

        public override int Health { get; set; } = 20;
        public override int Strength { get; set; } = 2;
        public override int Money { get; set; }
        public override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player player)
            {
                Figth(player);
                return true;
            }
            return false;
        }

        protected override void OnDeath()
        {
            Debug.Log("Well, I was already dead anyway...");
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
                nextActionTime += period;
                OnUpdate(Time.deltaTime);
            }

            //OnUpdate(Time.deltaTime * 0.2f);
            //OnUpdate(Time.deltaTime * 1000);
        }



        private float nextActionTime = 0.0f;
        public float period = 0.7f;
    }
}
