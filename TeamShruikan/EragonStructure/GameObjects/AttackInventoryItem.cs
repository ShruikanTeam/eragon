using EragonStructure.Structs;

namespace EragonStructure.GameObjects
{
using System;
    public abstract class AttackInventoryItem : InventoryItem
    {
        protected AttackInventoryItem(Point point, Size size, Picture picture) : base(point, size, picture)
        {
        }

        private decimal attackValue;

        // value of the attack
        public decimal AttackValue
        {
            get
            {
                return this.attackValue;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Attack value cannot be negative value");
                }
                this.attackValue = value;
            }
        }

    }
}
