using System;
using Assets.Source.Core;
using DungeonCrawl.Actors.Characters;
using DungeonCrawl.Actors.Static;
using DungeonCrawl.Core;
using UnityEngine;

namespace DungeonCrawl.Actors
{
    public abstract class Actor : MonoBehaviour
    {
        public void Sounds(string fileName)
        {
            AudioSource audio = GetComponent<AudioSource>();
            if (audio == null) audio = gameObject.AddComponent<AudioSource>();

            audio.clip = Resources.Load<AudioClip>(fileName);
            audio.playOnAwake = false;
            audio.Play();


        }
        public (int x, int y) Position
        {
            get => _position;
            set
            {
                _position = value;
                transform.position = new Vector3(value.x, value.y, Z);
            }
        }

        private (int x, int y) _position;
        private SpriteRenderer _spriteRenderer;

        private void Awake()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();

            SetSprite(DefaultSpriteId);
        }

        private void Update()
        {
            OnUpdate(Time.deltaTime);
        }

        public void SetSprite(int id)
        {
            _spriteRenderer.sprite = ActorManager.Singleton.GetSprite(id);
        }

        public void TryMove(Direction direction)
        {
            var vector = direction.ToVector();
            (int x, int y) targetPosition = (Position.x + vector.x, Position.y + vector.y);

            var actorAtTargetPosition = ActorManager.Singleton.GetActorAt(targetPosition);

            if (actorAtTargetPosition == null)
            {
                if (this.DefaultName == "Player")
                {
                    
                    CameraController.Singleton.Position = (targetPosition.x, targetPosition.y);
                    UserInterface.Singleton.SetText("", UserInterface.TextPosition.BottomRight);
                    UserInterface.Singleton.SetText("", UserInterface.TextPosition.MiddleLeft);

                }
                // No obstacle found, just move
                Position = targetPosition;
            }

            else
            {
                if (actorAtTargetPosition.OnCollision(this))
                {
                    if (this is Player)
                    {
                        CameraController.Singleton.Position = (targetPosition.x, targetPosition.y);

                        if (actorAtTargetPosition is Stair)
                        {
                            
                            ChangeMap();
                        }
                    }
                    // Allowed to move
                    Position = targetPosition;
                }
            }
        }

        /// <summary>
        ///     The previous map destroyed and the next created.
        /// </summary>
        public void ChangeMap()
        {
            if (this is Player player)
            {
                
                
                ActorManager.Singleton.DestroyAllActors();
                
                if (player.Position == (20, -18))
                {
                    
                    MapLoader.LoadMap(2, player);
                }
                else
                {
                    
                    MapLoader.LoadMap(1, player);
                }
            }
        }

        /// <summary>
        ///     Invoked whenever another actor attempts to walk on the same position
        ///     this actor is placed.
        /// </summary>
        /// <param name="anotherActor"></param>
        /// <returns>true if actor can walk on this position, false if not</returns>
        public virtual bool OnCollision(Actor anotherActor)
        {
            // All actors are passable by default
            return true;
        }

        /// <summary>
        ///     Invoked every animation frame, can be used for movement, character logic, etc
        /// </summary>
        /// <param name="deltaTime">Time (in seconds) since the last animation frame</param>
        protected virtual void OnUpdate(float deltaTime)
        {
        }

        /// <summary>
        ///     Can this actor be detected with ActorManager.GetActorAt()? Should be false for purely cosmetic actors
        /// </summary>
        public virtual bool Detectable => true;

        /// <summary>
        ///     Z position of this Actor (0 by default)
        /// </summary>
        public virtual int Z => 0;

        /// <summary>
        ///     Id of the default sprite of this actor type
        /// </summary>
        public abstract int DefaultSpriteId { get; }

        /// <summary>
        ///     Default name assigned to this actor type
        /// </summary>
        public abstract string DefaultName { get; set; }
    }
}