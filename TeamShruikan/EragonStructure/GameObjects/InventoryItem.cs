namespace EragonStructure.GameObjects
{
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
