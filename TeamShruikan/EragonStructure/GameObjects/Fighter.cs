namespace EragonStructure.GameObjects
{
    public class Fighter : Player
    {
        // Start of singleton pattern (singleton is a class
        // which only allows a single instance of itself to be created)
        private static Fighter instance = null;

        protected Fighter()
        {
            this.Name = "Brom";
            this.Attack = 20;
            this.Defense = 15;
            this.Health = 60;
            this.Range = 0;
        }

        public static Fighter GetInstance()
        {
            if (instance == null)
            {
                instance = new Fighter();
            }
            
            return instance;
        }

        // End of singleton pattern

    }
}
