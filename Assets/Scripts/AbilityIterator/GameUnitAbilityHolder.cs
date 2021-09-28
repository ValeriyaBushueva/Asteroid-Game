using System.Collections.Generic;
using UnityEngine;

namespace AbilityIterator
{
    public class GameUnitAbilityHolder : MonoBehaviour, IAbilityHolder
    {
        [SerializeField] private Ability defaultAbility;
        [SerializeField] private Ability specialAbility;
        [SerializeField] private List<Ability> generalAbilities;

        public IEnumerable<IAbility> Abilities
        {
            get
            {
                yield return defaultAbility;
                yield return specialAbility;
                
                foreach (var generalAbility in generalAbilities)
                {
                    yield return generalAbility;
                }
            }
        } 
    }
}