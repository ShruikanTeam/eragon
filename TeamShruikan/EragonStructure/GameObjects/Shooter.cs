namespace EragonStructure.GameObjects
{
    public class Shooter : Player
    {
        // Start of singleton pattern (singleton is a class
        // which only allows a single instance of itself to be created)
        private static Shooter instance = null;

        protected Shooter()
        {
            this.Name = "Eragon";
            this.Attack = 15;
            this.Defense = 5;
            this.Health = 40;
            this.Range = 15;
        }

        public static Shooter GetInstance()
        {
            if (instance == null)
            {
                instance = new Shooter();
            }
            
            return instance;
        }

        // End of singleton pattern
    }
}
