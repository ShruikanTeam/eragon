namespace Eragon
{
    using System;

    public abstract class Character : GameObject, IMovable
    {
        public string Name { get; set; }

        public Point StartPoint { get; set; }

        public Direction Direction { get; set; }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
