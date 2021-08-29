using System;
using DefaultNamespace;
using UnityEngine;

public class InstantiateBullet : MonoBehaviour
{
    [SerializeField] private Transform barrel;
    [SerializeField] private float force;
    
    public void BulletSpawn()
    {
        BulletBuilder.AsNewBullet()
            .WithPosition(barrel.position)
            .WithRotation(barrel.rotation)
            .WithForce(barrel.up * force)
            .Build();
    }
}