using System;
using UnityEngine;

namespace AbilityIterator
{
    [Serializable]
    public class Ability : IAbility
    {
        [SerializeField] private string name;
        [SerializeField] private DamageType damageType;
        [SerializeField] private int damage;

        public string Name => name;
        public DamageType DamageType => damageType;
        public int DamageAmount => damage;
    }
}