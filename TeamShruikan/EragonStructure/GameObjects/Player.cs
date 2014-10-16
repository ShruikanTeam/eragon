﻿namespace EragonStructure.GameObjects
{
    using System.Collections;

    using EragonStructure.Enumerations;
    using EragonStructure.Structs;
    using System.Collections.Generic;

    /// <summary>
    /// Allows us to create classes derived from this abstract class
    /// </summary>
    public abstract class Player : Creature, IPlayer, ILevelUp
    {
        private int level = 1;

        private int currentExperience;

        private int experienceNeeded;

        private PowerStats stats;

        private ICollection<IInventory> equipment;

        /// <summary>
        /// Initializes a new instance of the Player class with default 
        /// values for money and experience which will be later inherited</summary>
        /// <param name="point">The current point of the player</param>
        /// <param name="size">The size of the player</param>
        /// <param name="picture">The image of the player</param>
        /// <param name="name">The name of the player</param>
        protected Player(Point point, Size size, Picture picture, string name, int currentLevel)
            : base(point, size, picture, name)
        {
            this.Attack = 50;
            this.Defense = 50;
            this.Range = 1;
            this.CurrentHealthPoints = 100;
            this.MaxHealthPoints = 100;
            this.MovementSpeed = 5;
            this.CurrentExperience = 0;
            this.Money = 50m;
            this.Level = currentLevel;

            GetPlayerStats(this.Stats);
        }

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
        /// Gets or sets experience needed by the player to raise a level up
        /// </summary>
        public int ExperienceNeeded
        {
            get
            {
                return this.experienceNeeded;
            }

            private set
            {
                this.currentExperience = 500 * this.Level;
            }
        }

        /// <summary>
        /// Gets or sets the amount of money of the current player
        /// </summary>
        public decimal Money { get; set; }

        protected PowerStats Stats
        {
            get
            {
                return this.stats;
            }
            set
            {
                this.stats = value;
            }
        }

        public override void AttackEnemies(ICreature enemyCreature)
        {
            int damageDealed = this.Attack - enemyCreature.Defense;
            this.GainExperience(damageDealed);
        }

        public ICollection<IInventory> Equipment
        {
            get
            {
                return this.equipment;
            }
            set
            {
                this.equipment = value;
            }
        }

        /// <summary>
        /// Defines the way a player is gaining experience
        /// </summary>
        public void GainExperience(int experienceToAdd)
        {
            this.CurrentExperience += experienceToAdd;
        }

        public override void Move()
        {
            int horizontalPosition = this.CurrentPoint.X;
            int verticalPosition = this.CurrentPoint.Y;

            // This piece of code is copied from Yavor's form. I guess it should be implemented here, 
            // will leave commented for now. 
            //    switch (Settings.Direction)
            //    {
            //        case Direction.North:
            //            verticalPosition -= Settings.MoveSpeed;
            //            this.CurrentPoint = new Point(horizontalPosition, verticalPosition);
            //            break;
            //        case Direction.East:
            //            horizontalPosition += Settings.MoveSpeed;
            //            this.CurrentPoint= new Point(horizontalPosition, verticalPosition);
            //            break;
            //        case Direction.South:
            //            verticalPosition += Settings.MoveSpeed;
            //            this.CurrentPoint = new Point(horizontalPosition, verticalPosition);
            //            break;
            //        case Direction.West:
            //            horizontalPosition -= Settings.MoveSpeed;
            //            this.CurrentPoint = new Point(horizontalPosition, verticalPosition);
            //            break;
            //    }

            //    //Detect collission with game borders.
            //    if (horizontalPosition < 16)
            //    {
            //        Settings.Direction = Direction.East;
            //    }

            //    if (verticalPosition < 32)
            //    {
            //        Settings.Direction = Direction.South;
            //    }

            //    if (horizontalPosition > - 16)
            //    {
            //        Settings.Direction = Direction.West;
            //    }

            //    if (verticalPosition >  -32)
            //    {
            //        Settings.Direction = Direction.North;
            //    }
        }

        protected PowerStats GetPlayerStats(PowerStats stats)
        {
            stats.Attack += this.Attack;
            stats.Defense += this.Defense;
            stats.Range += this.Range;
            stats.CurrentHealth += this.CurrentHealthPoints;
            stats.MaximumHealth += this.MaxHealthPoints;

            return stats;
        }

        public PowerStats EquipPlayer(ICollection<IInventory> equipment, PowerStats playerStats)
        {
            foreach (var item in equipment)
            {
                playerStats.Attack += item.Stats.Attack;
                playerStats.Defense += item.Stats.Defense;
                playerStats.Range += item.Stats.Range;
                playerStats.MaximumHealth += item.Stats.MaximumHealth;
                playerStats.MovementSpeed += item.Stats.MovementSpeed;
            }

            return playerStats;
        }
    }
}