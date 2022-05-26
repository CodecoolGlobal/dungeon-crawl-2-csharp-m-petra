using UnityEngine;

namespace DungeonCrawl.Actors.Characters
{
    internal class Ghost : Character
    {
        protected override int DefaultSpriteId
        {
            get => 314;
            set => throw new System.NotImplementedException();
        }

        public override string DefaultName
        {
            get => "Ghost";
            set { }
        }
        public Player Player { get; set; }
        public override int Health { get; set; } = 30;
        public override int Strength { get; set; } = 3;
        public override int Money { get; set; }

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
                nextActionTime = Time.time + period;
                OnUpdate(Time.deltaTime);
            }
        }

        private float nextActionTime = 0.0f;
        private float period = 0.7f;
    }
}
