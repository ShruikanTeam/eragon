namespace EragonStructure.GameObjects
{
    public interface ICreature
    {
        /// <summary>
        /// Gets or sets the radius in which the creature can deal damage
        /// </summary>
        int Range { get; set; }

        /// <summary>
        /// Define the attack method
        /// </summary>
        void AttackEnemies(Creature enemyCreature);
    }
}
