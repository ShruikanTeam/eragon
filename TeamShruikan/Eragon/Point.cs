namespace Eragon
{
    using System;

    /// <summary>
    /// Defines the position of the game object
    /// </summary>
    public struct Point
    {
        #region Fields
        /// <summary>
        /// Storing data for xPosition
        /// </summary>
        private int x;

        /// <summary>Storing data for yPosition
        /// </summary>
        private int y;

        #endregion

        #region Constructor

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        #endregion
    }
}
