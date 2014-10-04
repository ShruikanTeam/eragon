using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eragon
{
    /// <summary>
    /// Allows object to change their position on the game field
    /// </summary>
    public interface IMovable 
    {
        /// <summary>
        /// Gets or sets the starting position 
        /// </summary>
        Point StartPoint { get; set; }

        /// <summary>
        /// Gets or sets the direction of movement
        /// </summary>
        Direction Direction { get; set; }

        /// <summary>
        /// Allows the object to change their position on the map
        /// </summary>
        void Move();
    }
}
