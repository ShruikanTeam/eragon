namespace EragonStructure.GameObjects
{
    using System;

    using EragonStructure.Structs;

    /// <summary>
    /// Defines the character type with its properties
    /// </summary>
    public abstract class Character : GameObject
    {
        protected Character(Point point, Size size, Picture picture, string name)
            : base(point, size, picture)
        {
            this.Name = name;
        }
        
        /// <summary>
        /// Gets or sets the name of the character
        /// </summary>
        protected string Name { get; set; }
    }
}
