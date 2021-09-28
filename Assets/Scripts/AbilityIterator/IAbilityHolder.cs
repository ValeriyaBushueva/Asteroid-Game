using System.Collections.Generic;

namespace AbilityIterator
{
    public interface IAbilityHolder
    {
        IEnumerable<IAbility> Abilities { get; }
    }
}