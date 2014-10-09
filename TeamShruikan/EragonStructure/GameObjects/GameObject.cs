namespace EragonStructure.GameObjects
{
    using EragonStructure.Structs;
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
