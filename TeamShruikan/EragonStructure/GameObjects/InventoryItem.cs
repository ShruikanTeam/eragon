namespace EragonStructure.GameObjects
{
    using System;
    public abstract class InventoryItem : IInventoryItem
    {
        public string Name
        {
            get;
            protected set;
        }

        public int Value
        {
            get;
            set;
        }

    }
}