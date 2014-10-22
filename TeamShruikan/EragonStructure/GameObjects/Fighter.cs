namespace EragonStructure.GameObjects
{
    using EragonStructure.Structs;

    public class Fighter : Player
    {
        public Fighter(Point point, Size size, Picture picture, string name, int attack, int defence, int range, int currentHealthPoints, int maxHealthPoints, int movementsSpeed, int currentLevel, int experienceNeeded, bool imgDir)
            : base(point, size, picture, name, attack, defence, range, currentHealthPoints, maxHealthPoints, movementsSpeed, currentLevel, experienceNeeded, imgDir)
        {
            this.Attack += 10;
            this.Defense += 10;
            this.CurrentHealthPoints += 10;
            this.MaxHealthPoints += 10;
            this.Range += 1;
        }
    }
}
