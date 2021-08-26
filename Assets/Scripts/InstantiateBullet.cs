using System;
using UnityEngine;

public class InstantiateBullet: MonoBehaviour
    {
        [SerializeField] private Rigidbody2D bullet;
        [SerializeField] private Transform barrel;
        [SerializeField] private float force;

        private ObjectPooler objectPooler;

        private void Start()
        {
            objectPooler =ObjectPooler.Instance;
        }

        public void BulletSpawn()
        {
            ObjectPooler.Instance.SpawnFromPool("Laser", transform.position, Quaternion.identity);
            // var temAmmunition = Instantiate(bullet, barrel.position, barrel.rotation);
            // temAmmunition.AddForce(barrel.up * force);
        }
    }
