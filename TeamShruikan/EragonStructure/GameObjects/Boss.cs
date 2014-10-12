namespace EragonStructure.GameObjects
{
    using EragonStructure.Structs;

    public class Boss : Enemy
    {
        public Boss(Point point, Size size, Picture picture, string name)
            : base(point, size, picture, name)
        {
            this.Attack = 100;
            this.Defense = 100;
            this.MaxHealthPoints = 2000;
            this.CurrentHealthPoints = 200;
        }
    }
}
