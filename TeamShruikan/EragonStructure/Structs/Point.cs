namespace EragonStructure.Structs
{
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

        /// <summary>
        /// Initializes the position of the object on the map
        /// </summary>
        /// <param name="x">Horizontal coordinates</param>
        /// <param name="y">Vertical coordinates</param>
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the horizontal position of the game object
        /// </summary>
        public int X
        {
            get
            {
                return this.x;
            }

            set
            {
                this.x = value;
            }
        }

        /// <summary>
        /// Gets or sets the vertical position of the game object
        /// </summary>
        public int Y
        {
            get
            {
                return this.y;
            }

            set
            {
                this.y = value;
            }
        }

        #endregion
    }
}
