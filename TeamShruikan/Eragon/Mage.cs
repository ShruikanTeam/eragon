namespace Eragon
{
    public sealed class Mage : Player
    {
        // Start of singleton pattern (singleton is a class
        // which only allows a single instance of itself to be created)
        private static Mage instance = null;

        protected Mage()
        {
            
        }

        public static Mage GetInstance()
        {
            if (instance == null)
            {
                instance = new Mage();
            }

            return instance;
        }

        // End of singleton pattern
    }
}
