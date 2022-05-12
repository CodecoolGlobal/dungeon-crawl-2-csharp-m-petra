using UnityEngine;

namespace DungeonCrawl.Actors.Characters
{
    internal class Ghost : Character
    {
        public override int DefaultSpriteId => 314;
        public override string DefaultName
        {
            get => "Ghost";
            set { }
        }


        public Player Player { get; set; }

        public override int Health { get; set; } = 30;
        public override int Strength { get; set; } = 3;

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
            Debug.Log("Well, I am ghost...");
        }

        protected override void OnUpdate(float deltaTime)
        {

            if (Player.Position.x < Position.x)
                TryMove(Direction.Up);

            if (Player.Position.x > Position.x)
                TryMove(Direction.Down);

            if (Player.Position.y > Position.y)
                TryMove(Direction.Right);

            if (Player.Position.y < Position.y)
                TryMove(Direction.Left);

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