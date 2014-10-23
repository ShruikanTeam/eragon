using EragonStructure.Structs;

namespace EragonStructure.GameObjects
{
    using System;
    using EragonStructure.Enumerations;
    class BasicAttack : AttackInventoryItem, IDrawable
    {
        public BasicAttack(Point point, Size size, Picture picture, BasicAttackItemNames item)
            : base(point, size, picture)
        {
            this.Name = item.ToString();
            this.AttackValue = (int)item;

        }

        public void Draw(System.Drawing.Graphics g)
        {
            throw new NotImplementedException();
        }
    }
}
