namespace EragonStructure.Structs
{
    using System;

    /// <summary>
    /// Defines the size of an object
    /// </summary>
    public struct Size
    {
        #region Fields

        /// <summary>
        /// Storing the width of the current object
        /// </summary>
        private int width;

        /// <summary>
        /// Storing the width of the current object
        /// </summary>
        private int height;

        #endregion 

        #region Constructors

        /// <summary>
        /// Initializes the size that a new object will have
        /// </summary>
        /// <param name="width">The width of the object</param>
        /// <param name="height">The height of the object</param>
        public Size(int width, int height)
            : this()
        {
            this.Width = width;
            this.Height = height;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the width of the object
        /// </summary>
        public int Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width", "The width cannot be negative. Enter a valid value.");
                }

                this.width = value;
            }
        }

        /// <summary>
        /// Gets or sets the height of the object
        /// </summary>
        public int Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height", "The heightcannot be negative. Enter a valid value.");
                }

                this.height = value;
            }
        }

        #endregion
    }
}
