namespace Eragon
{
    /// <summary>
    /// Defines that object can draw itself on the game fields
    /// </summary>
    public interface IDrawable
    {
        /// <summary>
        /// Gets or sets the coordinates of an object
        /// </summary>
        Point Point { get; set; }

        /// <summary>
        /// Gets or sets the image of the current object on the game field
        /// </summary>
        Picture Picture { get; set; }

        /// <summary>
        /// Draws the object on the game field
        /// </summary>
        /// <param name="point"></param>
        void Draw(Point point);
    }
}
