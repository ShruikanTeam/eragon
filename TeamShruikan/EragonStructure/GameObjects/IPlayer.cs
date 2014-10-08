﻿namespace EragonStructure.GameObjects
{
    public interface IPlayer
    {
        /// <summary>
        /// Gets or sets the money of the player
        /// </summary>
        decimal Money { get; set; }

        /// <summary>
        /// Gets or sets the the experience gained by the player
        /// </summary>
        int Experience { get; set; }

        /// <summary>
        /// Defines the way the player is gaining experience
        /// </summary>
        void GainExperience();
    }
}
