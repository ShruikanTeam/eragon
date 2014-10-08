namespace EragonStructure.GameObjects
{
    using System;

    /// <summary>
    /// Defines the character type with its properties
    /// </summary>
    public abstract class Character : GameObject
    {
        protected Character()
        {
        }
        
        /// <summary>
        /// Gets or sets the name of the character
        /// </summary>
        protected string Name { get; set; }
    }
}
