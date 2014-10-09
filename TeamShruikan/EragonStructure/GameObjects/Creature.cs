namespace EragonStructure.GameObjects
{
    using EragonStructure.Structs;
    using EragonStructure.Enumerations;

    /// <summary>
    /// Defines that a movable character with attack and defense abilities can be created 
    /// </summary>
    public abstract class Creature : Character, ICreature, IMovable
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
        /// Defines the way creatures are dealing damage to enemyCreature
        /// </summary>
        /// <param name="enemyCreature">The target </param>
        public void AttackEnemies(Creature enemyCreature)
        {
            enemyCreature.Health -= this.Attack - enemyCreature.Defense;
        }

        /// <summary>
        /// Allows the character to change its position on the map
        /// </summary>
        public abstract void Move();
    }
}
