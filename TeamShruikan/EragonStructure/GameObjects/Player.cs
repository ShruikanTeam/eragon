namespace EragonStructure.GameObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using EragonStructure.Enumerations;
    using EragonStructure.Structs;

    /// <summary>
    /// Allows us to create classes derived from this abstract class
    /// </summary>
    public abstract class Player : Creature, IPlayer, ILevelUp, IMovable, IDrawable
    {
        #region Fields

        private int level = 1;

        private int currentExperience;

        private int experienceNeeded;

        private PowerStats stats;

        private ICollection<IInventoryItem> equipment;

        private ICollection<IInventoryItem> stash;

        private IInventoryItem attackItem;

        private IInventoryItem defenseItem;

        private bool imageOriantation;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the Player class with default 
        /// values for money and experience which will be later inherited</summary>
        /// <param name="point">The current point of the player</param>
        /// <param name="size">The size of the player</param>
        /// <param name="picture">The image of the player</param>
        /// <param name="name">The name of the player</param>
        protected Player(Point point, Size size, Picture picture, string name, int attack, int defence, int range,
            int currentHealthPoints, int maxHealthPoints, int movementsSpeed, int currentLevel, int experienceNeeded, bool imgDir)
            : base(point, size, picture, name, attack, defence, range, currentHealthPoints, maxHealthPoints, movementsSpeed)
        {
            this.Attack = 50;
            this.Defense = 50;
            this.Range = 1;
            this.CurrentHealthPoints = 100;
            this.MaxHealthPoints = 100;
            this.MovementSpeed = 5;
            this.CurrentExperience = 0;
            this.imageOriantation = imgDir;
            this.Money = 50m;
            this.Level = currentLevel;
            this.experienceNeeded = experienceNeeded;
            if (this.attackItem != null)
            {
                this.Attack += this.AttackItem.Value;    
            }

            if (this.DefenseItem != null)
            {
                this.Defense += this.DefenseItem.Value;   
            }
            
            // this.Equipment = new List<IInventoryItem>();
            // this.SetPlayerStats();                     // Initializes default player stats 
            // this.AddItemsStats(this.equipment);   // Add item stats to the player stats
        }

        #endregion

        #region Properties

        public int Level
        {
            get
            {
                return this.level;
            }

            private set
            {
                if (this.CurrentExperience >= this.ExperienceNeeded)
                {
                    this.level += 1;
                }
            }
        }

        /// <summary>
        /// Gets or sets the initial position of the character
        /// </summary>
        public Point CurrentPoint { get; set; }

        /// <summary>
        /// Gets or sets the movement direction of the character
        /// </summary>
        public Direction Direction { get; set; }

        /// <summary>
        /// Gets or sets the current experience of the player
        /// </summary>
        public int CurrentExperience
        {
            get
            {
                return this.currentExperience;
            }

            set
            {
                this.currentExperience += value;

                if (value < 0)
                {
                    value = 0;
                }

                if (this.currentExperience >= this.ExperienceNeeded)
                {
                    this.ExperienceNeeded = value;
                }
            }
        }

        /// <summary>
        /// Gets the experience needed by the player to raise a level up
        /// </summary>
        public int ExperienceNeeded
        {
            get { return this.experienceNeeded; }
            private set { this.currentExperience = 500 * this.Level; }
        }

        /// <summary>
        /// Gets or sets the amount of money of the current player
        /// </summary>
        public decimal Money { get; set; }

        /// <summary>
        /// Gets or sets the items that player is equipped with.
        /// </summary>

        ///// <summary>
        ///// Gets or sets the items that player is equipped with.
        ///// </summary>
        //public ICollection<IInventoryItem> Equipment
        //{
        //    get
        //    {
        //        return this.equipment;
        //    }

        //    set
        //    {
        //        this.equipment = new List<IInventoryItem>(this.equipment);
        //    }
        //}

        /*
        /// <summary>
        /// Gets or sets the player's items 
        /// </summary>
        public ICollection<IInventoryItem> Stash
        {
            get { return this.stash; }
            set { this.equipment = value; }
        }
        */

        /// <summary>
        /// Gets or sets the player stats (Attack, Defense, Range, Maximum health points and Movement speed).
        /// </summary>
        protected PowerStats Stats
        {
            get { return this.stats; }
            set { this.stats = value; }
        }

        public IInventoryItem AttackItem
        {
            get
            {
                return this.attackItem;
            }

            set
            {
                this.attackItem = value;
            }
        }

        public IInventoryItem DefenseItem
        {
            get
            {
                return this.defenseItem;
            }

            set
            {
                this.defenseItem = value;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Defines the way a player is gaining experience
        /// </summary>
        /// <param name="experienceToAdd">The amount of experience added to the current experience points.</param>
        public void GainExperience(int experienceToAdd)
        {
            this.CurrentExperience += experienceToAdd;
        }

        public override void AttackEnemies(ICreature enemyCreature)
        {
            int damageDealed = this.Attack - enemyCreature.Defense;
            this.GainExperience(damageDealed);
        }

        /// <summary>
        /// Defines the way the player is changing its position on the screen.
        /// </summary>
        public void Move()
        {
            int horizontalPosition = this.Point.X;
            int verticalPosition = this.Point.Y;

            // This piece of code is copied from Yavor's form. I guess it should be implemented here, 
            // will leave commented for now. 
            switch (this.Direction)
            {
                case Direction.North:
                    verticalPosition -= this.MovementSpeed;
                    this.Point = new Point(horizontalPosition, verticalPosition);
                    break;
                case Direction.East:
                    horizontalPosition += this.MovementSpeed;
                    this.Point = new Point(horizontalPosition, verticalPosition);
                    break;
                case Direction.South:
                    verticalPosition += this.MovementSpeed;
                    this.Point = new Point(horizontalPosition, verticalPosition);
                    break;
                case Direction.West:
                    horizontalPosition -= this.MovementSpeed;
                    this.Point = new Point(horizontalPosition, verticalPosition);
                    break;
            }
        }

        /// <summary>
        /// Equip player with new collected items 
        /// </summary>
        /// <param name="item">The set of items the player is equipped with.</param>
        protected virtual void EquipPlayer(IInventoryItem item)
        {
            var itemInInventory = this.equipment.Any(i => i.Name.Equals(item.Name));

            if (itemInInventory)
            {
                var equipedItem = this.equipment.First(i => i.Name.Equals(item.Name));
                this.ChooseItemToEquip(item, equipedItem);
            }
            else
            {
                this.equipment.Add(item);
            }
        }

        /// <summary>
        /// Let the player choose to keep the item that he already posses or to equip the new item
        /// </summary>
        /// <param name="newItem">The new collected item</param>
        /// <param name="oldItem">The old already equipped item</param>
        private void ChooseItemToEquip(IInventoryItem newItem, IInventoryItem oldItem)
        {
            // TODO Decide how the player chooses item to equip
            if (true)
            {
                this.equipment.Remove(oldItem);
                this.equipment.Add(newItem);
            }
        }

        protected virtual void UnequipPlayer(IInventoryItem item)
        {
            if (!this.equipment.Contains(item))
            {
                throw new ArgumentNullException("item", "Item is not in the player equipment");
            }

            this.equipment.Remove(item);

            //foreach (var stat in playerEquipment)
            //{
            //    // Will uncomment when items stats are implemented 
            //    this.stats.Attack -= item.Stats.Attack;
            //    this.stats.Defense -= item.Stats.Defense;
            //    this.stats.Range -= item.Stats.Range;
            //    this.stats.MaximumHealth -= item.Stats.MaximumHealth;
            //    this.stats.MovementSpeed -= item.Stats.MovementSpeed;
            //}
        }

        /// <summary>
        /// Sets the initial player stats.
        /// </summary>
        /// <returns>Returns actualized initial player stats.</returns>
        protected PowerStats SetPlayerStats()
        {
            this.stats.Attack += this.Attack;
            this.stats.Defense += this.Defense;
            this.stats.Range += this.Range;
            this.stats.CurrentHealth += this.CurrentHealthPoints;
            this.stats.MaximumHealth += this.MaxHealthPoints;

            return this.stats;
        }

        private void AddItemsStats(ICollection<IInventoryItem> equipment)
        {
            foreach (var item in equipment)
            {
                this.Attack += item.Value;
                this.Defense += item.Value;
            }
        }

        #endregion
    }
}
