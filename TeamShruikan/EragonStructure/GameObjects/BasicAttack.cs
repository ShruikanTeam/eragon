namespace EragonStructure.GameObjects
{
    using System;
    using EragonStructure.Enumerations;
    class BasicAttack : AttackInventoryItem
    {

        public BasicAttack(BasicAttackItemNames item)
        {
            this.Name = item.ToString();
            this.AttackValue = (int)item;
        }

    }
}
