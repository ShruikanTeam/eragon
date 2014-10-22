namespace EragonStructure.GameObjects
{
    using System;
    using EragonStructure.Enumerations;
    class BasicDefence : DeffenseInventoryItem
    {
        public BasicDefence(Defence item)
        {
            this.Name = item.ToString();
            this.DeffenseValue = (int)item;
        }

        
    }
}
