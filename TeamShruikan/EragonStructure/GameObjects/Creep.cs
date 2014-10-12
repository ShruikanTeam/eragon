namespace EragonStructure.GameObjects
{
    using EragonStructure.Structs;

    public class Creep : Enemy
    {
        public Creep(Point point, Size size, Picture picture, string name)
            : base(point, size, picture, name)
        {
        }
    }
}
