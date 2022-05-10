using UnityEngine;

namespace DungeonCrawl.Actors.Characters
{
    internal class Monster : Character
    {
        public override bool OnCollision(Actor anotherActor)
        {
            return false;
        }

        protected override void OnDeath()
        {
            Debug.Log("Well, I am monster...");
        }

        public override int DefaultSpriteId => 317;
        public override string DefaultName => "Monster";
    }
}
