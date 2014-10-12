namespace EragonStructure.GameObjects
{
    using System.Collections;

    using EragonStructure.Structs;

    public abstract class PassiveCharacter : Character
    {
        protected PassiveCharacter(Point point, Size size, Picture picture, string name)
            : base(point, size, picture, name)
        {
            
        }
    }
}
