namespace EragonStructure.GameObjects
{
    using EragonStructure.Structs;

    public abstract class GameObject : IDrawable
    {
        protected GameObject(Point point, Size size, Picture picture)
        {
            this.Point = point;
            this.Size = size;
            this.Picture = picture;
        }

        public Size Size { get; set; }

        public Point Point { get; set; }

        public Picture Picture { get; set; }

        public void Draw(System.Drawing.Graphics g)
        {
            g.DrawImage(Picture.Image, Point.X, Point.Y);
        }
    }
}
