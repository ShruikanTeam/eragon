namespace EragonStructure.GameObjects
{
using System;
    public abstract class AttackInventoryItem : InventoryItem
    {

        public string Name
        {
            get;
            set;
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
