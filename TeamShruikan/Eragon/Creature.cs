namespace Eragon
{
    /// <summary>
    /// Defines that a movable character with attack and defense abilities can be created 
    /// </summary>
    public abstract class Creature : Character, ICreature
    {
        /// <summary>
        /// Gets or sets the attack points of the character
        /// </summary>
        public double Attack { get; set; }

        /// <summary>
        /// Gets or sets the defense points of the character
        /// </summary>
        public double Defense { get; set; }

        /// <summary>
        /// Gets or sets the health points of the character
        /// </summary>
        public double Health { get; set; }

        /// <summary>
        /// Gets or sets the experience of the hero
        /// </summary>
        public int Experience { get; set; }
        
        /// <summary>
        /// Gets or sets the radius in which the character can deal damage
        /// </summary>
        public int Range { get; set; }

        void ICreature.Attack()
        {
            throw new System.NotImplementedException();
        }
    }
}
