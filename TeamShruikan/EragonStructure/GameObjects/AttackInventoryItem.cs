namespace EragonStructure.GameObjects
{
using System;
    public abstract class AttackInventoryItem : InventoryItem
    {
        private decimal range;
        private decimal attackValue;
        // range of the attack
        public decimal Range
        {
            get
            {
                return this.range;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Range cannot be negative value");
                }

                this.range = value;
            }
        }

        // value of the attack
        public decimal AttackValue
        {
            get
            {
                return this.range;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Attack value cannot be negative value");
                }
                this.range = value;
            }
        }

    }
}
