namespace Eragon
{
    public abstract class Player : Creature, IPlayer
    {
        /// <summary>
        /// Initializes a new instance of the Player class with default 
        /// values for money and experience which will be later inherited
        /// </summary>
        protected Player()
        {
            this.Money = 50m;
            this.Experience = 0;
        }

        /// <summary>
        /// Gets or sets the amount of money of the current player
        /// </summary>
        public decimal Money { get; set; }

        /// <summary>
        /// Gets or sets the experience of the hero
        /// </summary>
        public int Experience { get; set; }
        
        public void GainExperience()
        {
            throw new System.NotImplementedException();
        }
    }
}
