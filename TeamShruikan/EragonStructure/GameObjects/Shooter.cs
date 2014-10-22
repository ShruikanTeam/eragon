namespace EragonStructure.GameObjects
{
    using EragonStructure.Structs;

    public class Shooter : Player
    {
        public Shooter(Point point, Size size, Picture picture, string name, int attack, int defence, 
            int range, int currentHealthPoints, int maxHealthPoints, int movementsSpeed, int currentLevel, int experienceNeeded, bool imgDir)
            : base(point, size, picture, name, attack, defence, range, currentHealthPoints, maxHealthPoints, movementsSpeed, currentLevel, experienceNeeded, imgDir)
        {
            this.Attack += 5;
            this.Defense -= 10;
            this.Range = 10;
        }
    }
}
