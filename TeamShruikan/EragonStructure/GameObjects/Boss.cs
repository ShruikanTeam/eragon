namespace EragonStructure.GameObjects
{
    using EragonStructure.Structs;

    public class Boss : Enemy
    {
        public Boss(Point point, Size size, Picture picture, string name, int attack, int defence, int range, int currentHealthPoints, int maxHealthPoints, int movementsSpeed)
            : base(point, size, picture, name, attack, defence, range, currentHealthPoints, maxHealthPoints, movementsSpeed)
        {
            this.Attack = 100;
            this.Defense = 100;
            this.MaxHealthPoints = 2000;
            this.CurrentHealthPoints = 200;
        }
    }
}
