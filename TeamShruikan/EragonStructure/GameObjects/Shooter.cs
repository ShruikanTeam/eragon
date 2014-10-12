namespace EragonStructure.GameObjects
{
    using EragonStructure.Structs;

    public class Shooter : Player
    {
        public Shooter(Point point, Size size, Picture picture, string name)
            : base(point, size, picture, name)
        {
            this.Attack += 5;
            this.Defense -= 10;
            this.Range = 10;
        }
    }
}
