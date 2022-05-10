using DungeonCrawl.Core;

namespace DungeonCrawl.Actors.Static
{
    public class Stair : Actor
    {
        public override int DefaultSpriteId => 287;
        public override string DefaultName => "Stair";

        public override bool Detectable => true;
        public override bool OnCollision(Actor anotherActor)
        {
            switch (anotherActor.DefaultName)
            {
                case "Player" when Position == (20, -19):
                    ActorManager.Singleton.DestroyAllActors();
                    MapLoader.LoadMap(2);
                    return base.OnCollision(anotherActor);
                default:
                    ActorManager.Singleton.DestroyAllActors();
                    MapLoader.LoadMap(1);
                    return base.OnCollision(anotherActor);
            }
        }
    }  
}
