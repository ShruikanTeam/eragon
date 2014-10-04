namespace Eragon
{
    public interface ICreature
    {
        int Range { get; set; }

        /// <summary>
        /// Define the attack method
        /// </summary>
        void Attack();
    }
}
