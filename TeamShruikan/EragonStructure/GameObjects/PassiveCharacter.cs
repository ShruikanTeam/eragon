namespace EragonStructure.GameObjects
{
    using System.Collections;

    using EragonStructure.Structs;

    public abstract class PassiveCharacter : Creature
    {
        //Point point, Size size, Picture picture, string name, int attack, int defence, int range, int currentHealthPoints, int maxHealthPoints, int movementsSpeed
        protected PassiveCharacter(Point point, Size size, Picture picture, string name, int defence, int range, int currentHealthPoints, int movementsSpeed)
            : base(point, size, picture, name, 0, defence, range, currentHealthPoints, currentHealthPoints, movementsSpeed)
        {
            
        }
    }
}
