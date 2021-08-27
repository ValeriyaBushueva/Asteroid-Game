using System;
using UnityEngine;

    public class BulletCollision: MonoBehaviour

    {
        public void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Enemy"))
            {
                Destroy(other.gameObject);
            }
        }
    }
