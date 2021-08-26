using System.Collections;
using UnityEngine;

namespace DefaultNamespace
{
    public class PooledBullet : MonoBehaviour, IPooledObject
    {
        [SerializeField] private float secondsToDestroy = 2;
        [SerializeField] private Rigidbody2D rigidbody2D;

        private string poolTag;
        private ObjectPooler pool;
        
        public void OnObjectSpawn(string poolTag, ObjectPooler pool)
        {
            this.poolTag = poolTag;
            this.pool = pool;

            StartCoroutine(SelfDestroy());
        }

        private IEnumerator SelfDestroy()
        {
            yield return new WaitForSeconds(secondsToDestroy);
            Despawn();
        }

        private void Despawn()
        {
            rigidbody2D.velocity = Vector2.zero;
            pool.ReturnToPool(poolTag, gameObject);
        }
    }
}