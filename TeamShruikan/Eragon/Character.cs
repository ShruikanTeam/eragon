namespace Eragon
{
    using System;

    /// <summary>
    /// Defines the character type with its properties
    /// </summary>
    public abstract class Character : GameObject, IMovable
    {
        protected Character()
        {
            this.StartPoint = new Point(1, 1);
        }

        /// <summary>
        /// Gets or sets the initial position of the character
        /// </summary>
        public Point StartPoint { get; set; }

        /// <summary>
        /// Gets or sets the movement direction of the character
        /// </summary>
        public Direction Direction { get; set; }

        /// <summary>
        /// Gets or sets the name of the character
        /// </summary>
        protected string Name { get; set; }

        /// <summary>
        /// Allows the character to change its position on the map
        /// </summary>
        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
