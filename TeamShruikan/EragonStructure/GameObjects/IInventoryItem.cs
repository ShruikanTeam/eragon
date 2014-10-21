namespace EragonStructure.GameObjects
{
    public interface IInventoryItem
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
