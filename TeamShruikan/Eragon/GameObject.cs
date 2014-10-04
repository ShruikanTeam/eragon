namespace Eragon
{
    public abstract class GameObject : IDrawable
    {
        public Point Point { get; set; }

        public Picture Picture { get; set; }

        public void Draw(Point point)
        {
            throw new System.NotImplementedException();
        }
    }
}
