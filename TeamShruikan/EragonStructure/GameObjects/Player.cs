namespace EragonStructure.GameObjects
{
    using EragonStructure.Enumerations;

    public abstract class Player : Creature, IPlayer
    {
        /// <summary>
        /// Initializes a new instance of the Player class with default 
        /// values for money and experience which will be later inherited
        /// </summary>
        protected Player()
            : base()
        {
            this.Money = 50m;
            this.Experience = 0;
        }

        /// <summary>
        /// Gets or sets the amount of money of the current player
        /// </summary>
        public decimal Money { get; set; }

        /// <summary>
        /// Gets or sets the experience of the hero
        /// </summary>
        public int Experience { get; set; }

        public void GainExperience()
        {
            throw new System.NotImplementedException();
        }

        public override void Move()
        {
            int horizontalPosition = this.CurrentPoint.X;
            int verticalPosition = this.CurrentPoint.Y;

            // This piece of code is copied from Yavor's form. I guess it should be implemented here. 
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
    }
}
