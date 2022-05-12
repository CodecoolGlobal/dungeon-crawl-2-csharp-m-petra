using Assets.Source.Core;
using DungeonCrawl.Actors;
using DungeonCrawl.Actors.Characters;
using UnityEngine;

namespace Assets.Source.Actors.Static
{
    public abstract class Item : Actor
    {
        public void Sounds(string fileName)
        {
            AudioSource audio = GetComponent<AudioSource>();
            if (audio == null) audio = gameObject.AddComponent<AudioSource>();

            audio.clip = Resources.Load<AudioClip>(fileName);
            audio.Play();

        }
        public override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player)
            {

                UserInterface.Singleton.SetText("Press E to pick up", UserInterface.TextPosition.BottomRight);
                Sounds("findItem");

            }
            return true;
        }
    }
}
