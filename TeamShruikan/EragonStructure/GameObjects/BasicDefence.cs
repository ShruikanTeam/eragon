using EragonStructure.Structs;

namespace EragonStructure.GameObjects
{
    using System;
    using EragonStructure.Enumerations;
    class BasicDefence : DeffenseInventoryItem
    {
        public BasicDefence(Point point, Size size, Picture picture, Defence item)
            : base(point, size, picture)
        {
            this.Name = item.ToString();
            this.DeffenseValue = (int)item;
        }
    }
}
