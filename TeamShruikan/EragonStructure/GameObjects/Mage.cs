namespace EragonStructure.GameObjects
{
    using EragonStructure.Structs;

    public class Mage : Player
    {
        public Mage(Point point, Size size, Picture picture, string name, int attack, int defence, int range, int currentHealthPoints, int maxHealthPoints, int movementsSpeed, int currentLevel, int experienceNeeded)
            : base(point, size, picture, name, attack, defence, range, currentHealthPoints, maxHealthPoints, movementsSpeed, currentLevel, experienceNeeded)
        {
            this.Attack += 10;
            this.Defense -= 5;
            this.Range = 10;
        }
    }
}
