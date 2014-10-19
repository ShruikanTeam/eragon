namespace EragonStructure.GameObjects
{
    using System;

    using EragonStructure.Enumerations;
    using EragonStructure.Structs;

    public abstract class Enemy : Creature, IMovable
    {
        protected Enemy(Point point, Size size, Picture picture, string name, int attack, int defence, int range, int currentHealthPoints, int maxHealthPoints, int movementsSpeed)
            : base(point, size, picture, name, attack, defence, range, currentHealthPoints, maxHealthPoints, movementsSpeed)
        {
        }


        /// <summary>
        /// Gets or sets the initial position of the character
        /// </summary>
        public Point CurrentPoint { get; set; }

        /// <summary>
        /// Gets or sets the movement direction of the character
        /// </summary>
        public Direction Direction { get; set; }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
