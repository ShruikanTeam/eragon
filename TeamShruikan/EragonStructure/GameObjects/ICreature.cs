namespace EragonStructure.GameObjects
{
    public interface ICreature
    {
        /// <summary>
        /// Gets or sets the radius in which the creature can deal damage
        /// </summary>
        int Range { get; set; }

        /// <summary>
        /// Gets or sets the attack points of the character
        /// </summary>
        int Attack { get; set; }

        /// <summary>
        /// Gets or sets the defense points of the character
        /// </summary>
        int Defense { get; set; }

        /// <summary>
        /// Gets or sets the current health points of the character
        /// </summary>
        int CurrentHealthPoints { get; set; }

        /// <summary>
        /// Gets or sets the maximum health points of a character
        /// </summary>
        int MaxHealthPoints { get; set; }

        /// <summary>
        /// Define the attack method
        /// </summary>
        /// <param name="enemyCreature">The target of our attack</param>
        void AttackEnemies(ICreature enemyCreature);
    }
}
