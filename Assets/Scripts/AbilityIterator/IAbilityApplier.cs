using System.Collections.Generic;

namespace AbilityIterator
{
    public interface IAbilityApplier
    {
        void ApplyAbilities(IEnumerable<IAbility> toApply);
    }
}