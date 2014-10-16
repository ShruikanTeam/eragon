namespace EragonStructure.GameObjects
{
    using EragonStructure.Structs;

    public class Shooter : Player
    {
        public Shooter(Point point, Size size, Picture picture, string name, int currentLevel)
            : base(point, size, picture, name, currentLevel)
        {
            this.Attack += 5;
            this.Defense -= 10;
            this.Range = 10;
        }
    }
}
