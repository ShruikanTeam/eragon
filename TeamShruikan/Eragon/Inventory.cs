public class Inventory
{
    protected bool Exist { get; set; }
    protected enum Types
    {
        Player,
        Enemy,
        Trader
    };
}