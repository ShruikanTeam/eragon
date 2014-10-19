namespace EragonStructure.GameObjects
{
    public abstract class DeffenseInventoryItem : InventoryItem
    {
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
