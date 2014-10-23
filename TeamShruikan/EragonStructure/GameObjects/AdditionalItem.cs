
using EragonStructure.Structs;

namespace EragonStructure.GameObjects
{
using System;

    public abstract class AdditionalItem : InventoryItem
    {
        protected AdditionalItem(Point point, Size size, Picture picture) : base(point, size, picture)
        {
            Power = "0";
        }

        private string power;

        // provide information for power that gives
        public string Power
        {
            get;
            set;
        }
    }

}
