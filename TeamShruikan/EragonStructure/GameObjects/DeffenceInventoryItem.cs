using System;
using EragonStructure.Structs;

namespace EragonStructure.GameObjects
{
    public abstract class DeffenseInventoryItem : InventoryItem
    {
        protected DeffenseInventoryItem(Point point, Size size, Picture picture) : base(point, size, picture)
        {
        }

        private decimal deffenseValue;

        public decimal DeffenseValue
        {
            get
            {
                return this.deffenseValue;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Attack value cannot be negative value");
                }
                this.deffenseValue = value;
            }
        }
    }
}
