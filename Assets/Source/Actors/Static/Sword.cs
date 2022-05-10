namespace DungeonCrawl.Actors.Static
{
    public class Sword : Actor
    {
        public override int DefaultSpriteId => 415; // 463
        public override string DefaultName => "Sword";

        public override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor.DefaultName == "Player")
            {
                // The item must be displayed on screen
                // (unless somebody stands on the same square)

                //Destroy(this);
                gameObject.SetActive(false);
            }

            return true;
        }
    }
}
