namespace EragonStructure.GameObjects
{
    using System;

    using EragonStructure.Enumerations;
    using EragonStructure.Structs;

    public abstract class Enemy : Creature, IMovable
    {
        protected Enemy(Point point, Size size, Picture picture, string name, int attack, int defence, int range, int currentHealthPoints, int maxHealthPoints, int movementsSpeed)
            : base(point, size, picture, name, attack, defence, range, currentHealthPoints, maxHealthPoints, movementsSpeed)
        {
        }


        /// <summary>
        /// Gets or sets the initial position of the character
        /// </summary>
        public Point CurrentPoint { get; set; }

        /// <summary>
        /// Gets or sets the movement direction of the character
        /// </summary>
        public Direction Direction { get; set; }

        protected IInventoryItem DropItem()
        {
            Random genRandom = new Random();
            int gen = genRandom.Next();
            var itemType = gen % 2 == 0 ? typeof(BasicAttackItemNames) : typeof(Defence);    
            Array values = Enum.GetValues(itemType);
            Random rand = new Random();

            if (itemType == typeof(BasicAttackItemNames))
            {
                BasicAttackItemNames itemRand = (BasicAttackItemNames)values.GetValue(rand.Next(values.Length));
                BasicAttack item = new BasicAttack(itemRand);

                return item;
            }
            else
            {
                Defence itemRand = (Defence)values.GetValue(rand.Next(values.Length));
                DeffenseInventoryItem item = new BasicDefence(itemRand);

                return item;
            }
            
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
