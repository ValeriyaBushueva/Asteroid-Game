using System;
using UnityEngine;

public class InstantiateBullet : MonoBehaviour
{
    [SerializeField] private Transform barrel;
    [SerializeField] private float force;
    
    public void BulletSpawn()
    {
        GameObject bullet = ObjectPooler.Instance.SpawnFromPool("Laser", barrel.position, barrel.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(barrel.up * force);
    }
}