using UnityEngine;


public class InstantiateBullet: MonoBehaviour
    {
        [SerializeField] private Rigidbody2D bullet;
        [SerializeField] private Transform barrel;
        [SerializeField] private float force;
        
        
        public void BulletSpawn()
        {
            var temAmmunition = Instantiate(bullet, barrel.position, barrel.rotation);
            temAmmunition.AddForce(barrel.up * force);
        }
    }
