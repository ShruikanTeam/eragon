namespace EragonStructure.GameObjects
{
    using EragonStructure.Enumerations;
    using EragonStructure.Structs;

    /// <summary>
    /// Defines that a movable character with attack and defense abilities can be created 
    /// </summary>
    public abstract class Creature : Character, ICreature, IMovable
    {
        private int currentHealth;

        protected Creature(Point point, Size size, Picture picture, string name)
            : base(point, size, picture, name)
        {
        }

        #region Properties

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
        public int Attack 
        {
            get
            {
                return this.Attack;
            }

            set
            {
                this.Attack = value;
            } 
        }

        /// <summary>
        /// Gets or sets the defense points of the character
        /// </summary>
        public int Defense { get; set; }

        /// <summary>
        /// Gets or sets the radius in which the character can deal damage
        /// </summary>
        public int Range { get; set; }

        /// <summary>
        /// Gets or sets the current health points of the character
        /// </summary>
        public int CurrentHealthPoints
        {
            get
            {
                return this.currentHealth;
            }

            set
            {
                if (value > this.MaxHealthPoints)
                {
                    this.currentHealth = this.MaxHealthPoints;
                }
                else
                {
                    this.currentHealth = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the maximum health points of a character
        /// </summary>
        public int MaxHealthPoints { get; set; }

        /// <summary>
        /// Gets or sets the speed of the character
        /// </summary>
        public int MovementSpeed { get; set; }

        /// <summary>
        /// Gets the current state of the character - Dead or Alive.
        /// </summary>
        public bool IsAlive
        {
            get
            {
                return this.currentHealth > 0 ? true : false;
            }
        }

        #endregion

        #region Methods

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

        #endregion
    }
}
