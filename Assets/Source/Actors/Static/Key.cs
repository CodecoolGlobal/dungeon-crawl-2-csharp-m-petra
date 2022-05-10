namespace DungeonCrawl.Actors.Static
{
    internal class Key : Actor
    {
        public override int DefaultSpriteId => 559;
        public override string DefaultName => "Key";
        public override int Z => -1;

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
