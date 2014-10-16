namespace EragonStructure.GameObjects
{
    using EragonStructure.Structs;

    public class Mage : Player
    {
        public Mage(Point point, Size size, Picture picture, string name, int currentLevel)
            : base(point, size, picture, name, currentLevel)
        {
            this.Attack += 10;
            this.Defense -= 5;
            this.Range = 10;
        }
    }
}
