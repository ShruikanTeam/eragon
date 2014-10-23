using EragonStructure.Structs;

namespace EragonStructure.GameObjects
{
    using System;
    public abstract class InventoryItem : GameObject, IInventoryItem
    {
        protected InventoryItem(Point point, Size size, Picture picture) : base(point, size, picture)
        {
        }

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