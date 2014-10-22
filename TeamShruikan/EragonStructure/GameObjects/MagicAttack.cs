
namespace EragonStructure.GameObjects
{
    using System;
    using EragonStructure.Enumerations;

    public class MagicAttack : AttackInventoryItem
    {
        public MagicAttack(MagicAttackItemsNames item)
        {
            this.Name = item.ToString();
            this.AttackValue = (int)item;
        }
    }
}
