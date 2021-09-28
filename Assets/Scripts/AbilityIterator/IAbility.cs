namespace AbilityIterator
{
    public interface IAbility
    {
        string Name { get; }
        DamageType DamageType { get; }
        int DamageAmount { get; }
    }
}