namespace EragonStructure.GameObjects
{
    using EragonStructure.Enumerations;
    using EragonStructure.Structs;

    /// <summary>
    /// Defines that a movable character with attack and defense abilities can be created 
    /// </summary>
    public abstract class Creature : Character, ICreature, IMovable
    {
        private int currentHealthPoints;

        protected Creature(Point point, Size size, Picture picture, string name)
            : base(point, size, picture, name)
        {
        }

        /// <summary>
        /// Gets or sets the radius in which the character can deal damage
        /// </summary>
        public int Range { get; set; }
        
        /// <summary>
        /// Gets or sets the initial position of the character
        /// </summary>
        public Point CurrentPoint { get; set; }

        /// <summary>
        /// Gets or sets the movement direction of the character
        /// </summary>
        public Direction Direction { get; set; }

        /// <summary>
        /// Gets or sets the attack points of the character
        /// </summary>
        public int Attack { get; set; }

        /// <summary>
        /// Gets or sets the defense points of the character
        /// </summary>
        public int Defense { get; set; }

        /// <summary>
        /// Gets or sets the current health points of the character
        /// </summary>
        public int CurrentHealthPoints
        {
            get
            {
                return this.currentHealthPoints;
            }

            set
            {
                if (value > this.MaxHealthPoints)
                {
                    this.currentHealthPoints = this.MaxHealthPoints;
                }

                this.currentHealthPoints = value;
            }
        }

        /// <summary>
        /// Gets or sets the maximum health points of a character
        /// </summary>
        public int MaxHealthPoints { get; set; }

        /// <summary>
        /// Defines the way creatures are dealing damage to enemyCreature
        /// </summary>
        /// <param name="enemyCreature">The target creature</param>
        public virtual void AttackEnemies(ICreature enemyCreature)
        {
            enemyCreature.CurrentHealthPoints -= this.Attack - enemyCreature.Defense;
        }

        /// <summary>
        /// Allows the character to change its position on the map
        /// </summary>
        public abstract void Move();
    }
}
