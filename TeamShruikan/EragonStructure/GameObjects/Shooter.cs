namespace EragonStructure.GameObjects
{
    using EragonStructure.Structs;

    public class Shooter : Player
    {
        public Shooter(Point point, Size size, Picture picture, string name, int attack, int defence, int range, int currentHealthPoints, int maxHealthPoints, int movementsSpeed, int currentLevel, int experienceNeeded)
            : base(point, size, picture, name, attack, defence, range, currentHealthPoints, maxHealthPoints, movementsSpeed, currentLevel, experienceNeeded)
        {
            this.Attack += 5;
            this.Defense -= 10;
            this.Range = 10;
        }
    }
}
