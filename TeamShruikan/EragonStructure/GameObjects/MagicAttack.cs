
using EragonStructure.Structs;

namespace EragonStructure.GameObjects
{
    using System;
    using EragonStructure.Enumerations;

    public class MagicAttack : AttackInventoryItem
    {
        public MagicAttack(Point point, Size size, Picture picture, MagicAttackItemsNames item)
            : base(point, size, picture)
        {
            this.Name = item.ToString();
            this.AttackValue = (int)item;
        }
    }
}
