namespace EragonStructure.GameObjects
{
    using EragonStructure.Structs;

    public class Creep : Enemy
    {
        public Creep(Point point, Size size, Picture picture, string name, int attack, int defence, int range, int currentHealthPoints, int maxHealthPoints, int movementsSpeed)
            : base(point, size, picture, name, attack, defence, range, currentHealthPoints, maxHealthPoints, movementsSpeed)
        {
        }
    }
}
