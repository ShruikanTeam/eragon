namespace EragonStructure
{
    /// <summary>
    /// Allows an object to gain levels and raise its experience
    /// </summary>
    public interface ILevelUp
    {
        /// <summary>
        /// Gets the current player level
        /// </summary>
        int Level { get; }

        /// <summary>
        /// Gets the player's current experience points
        /// </summary>
        int CurrentExperience { get; }

        /// <summary>
        /// Gets the experience needed for a player to gain additional level
        /// </summary>
        int ExperienceNeeded { get; }

        /// <summary>
        /// Defines the way player gain experience
        /// </summary>
        void GainExperience(int experienceToAdd);
    }
}
