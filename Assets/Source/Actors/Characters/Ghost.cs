using System;
using UnityEngine;

namespace DungeonCrawl.Actors.Characters
{
    internal class Ghost : Character
    {
        public override int DefaultSpriteId => 314;
        public override string DefaultName => "Ghost";

        public override int Health { get; set; } = 30;
        public override int Strength { get; set; } = 3;

        public override bool OnCollision(Actor anotherActor)
        {
            return false;
        }

        protected override void OnDeath()
        {
            Debug.Log("Well, I am ghost...");
        }

        protected override void OnUpdate(float deltaTime)
        {
            //var playerPosition = GameObject.FindGameObjectsWithTag("Player")[0].transform.position;
            //Debug.Log($"PLAYER IS AT {playerPosition}");

            //var playerPosition = Player.Position;

            var rd = new System.Random();
            int randNum = rd.Next(0, 5);
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