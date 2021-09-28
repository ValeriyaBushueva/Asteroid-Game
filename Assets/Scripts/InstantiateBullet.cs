using System;
using System.Collections.Generic;
using System.Linq;
using AbilityIterator;
using DefaultNamespace;
using UnityEngine;

public class InstantiateBullet : MonoBehaviour, IAbilityApplier
{
    [SerializeField] private Transform barrel;
    [SerializeField] private float force;

    private IEnumerable<IAbility> currentAbilities = Enumerable.Empty<IAbility>();

    private int Damage
    {
        get
        {
            int result = 0;
            foreach (var ability in currentAbilities)
            {
                result += ability.DamageAmount;
            }

            return result;
        }
    }
    
    public void BulletSpawn()
    {
        BulletBuilder.AsNewBullet()
            .WithPosition(barrel.position)
            .WithRotation(barrel.rotation)
            .WithForce(barrel.up * force)
            .WithDamage(Damage)
            .Build();
    }

    public void ApplyAbilities(IEnumerable<IAbility> toApply) => currentAbilities = toApply;
}