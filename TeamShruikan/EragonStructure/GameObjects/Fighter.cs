﻿namespace EragonStructure.GameObjects
{
    using EragonStructure.Structs;

    public class Fighter : Player
    {
        public Fighter(Point point, Size size, Picture picture, string name, int currentLevel, int experienceNeeded)
            : base(point, size, picture, name, currentLevel, experienceNeeded)
        {
            this.Attack += 10;
            this.Defense += 10;
            this.CurrentHealthPoints += 10;
            this.MaxHealthPoints += 10;
            this.Range += 1;
        }
    }
}
