namespace EragonStructure.GameObjects
{
    using EragonStructure.Structs;

    public sealed class Mage : Player
    {
        public Mage(Point point, Size size, Picture picture, string name)
            : base(point, size, picture, name)
        {
            this.Attack += 10;
            this.Defense -= 5;
            this.Range = 10;
        }
    }
}
