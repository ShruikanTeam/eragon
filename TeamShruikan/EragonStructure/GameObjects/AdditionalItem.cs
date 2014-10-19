
namespace EragonStructure.GameObjects
{
using System;

    public abstract class AdditionalItem : InventoryItem
    {
        private string power;

        // provide information for power that gives
        public string Power
        {
            get;
            set;
        }
    }

}
