using System;
using UnityEngine;

public class InstantiateBullet : MonoBehaviour, IPooledObject
{
    [SerializeField] private Rigidbody2D bullet;
    [SerializeField] private Transform barrel;
    [SerializeField] private float force;

    private ObjectPooler objectPooler;

  public  void OnObjectSpawn()
    {
        objectPooler = ObjectPooler.Instance;
    }

    public void BulletSpawn()
    {
        GameObject bullet = ObjectPooler.Instance.SpawnFromPool("Laser", transform.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody2D>().AddForce(barrel.up * force);
    }
}