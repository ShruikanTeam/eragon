namespace EragonStructure.GameObjects
{
    interface IInventoryItem
    {
        string Name
        {
            get;
        }

        int Value
        {
            get;
            set;
        }
    }
}
