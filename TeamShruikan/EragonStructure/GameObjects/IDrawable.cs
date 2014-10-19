namespace EragonStructure.GameObjects
{
    using EragonStructure.Structs;

    /// <summary>
    /// Defines that object can draw itself on the game fields
    /// </summary>
    public interface IDrawable
    {
        /// <summary>
        /// Draws the object on Graphic
        /// </summary>
        void Draw(System.Drawing.Graphics g);
        /*
        /// <summary>
        /// Gets or sets the coordinates of an object
        /// </summary>
        Point Point { get; set; }

        /// <summary>
        /// Gets or sets the image of the current object on the game field
        /// </summary>
        Picture Picture { get; set; }

        /// <summary>
        /// Gets or sets the size of the object
        /// </summary>
        Size Size { get; set; }
         * */
    }
}
