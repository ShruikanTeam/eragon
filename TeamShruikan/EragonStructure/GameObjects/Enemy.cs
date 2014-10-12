namespace EragonStructure.GameObjects
{
    using System;

    using EragonStructure.Structs;

    public abstract class Enemy : Creature
    {
        private int currentHealthPoints;

        protected Enemy(Point point, Size size, Picture picture, string name)
            : base(point, size, picture, name)
        {
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}
