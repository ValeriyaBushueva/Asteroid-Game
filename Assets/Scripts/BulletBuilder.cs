using UnityEngine;
using UnityEngine.SpatialTracking;

namespace DefaultNamespace
{
    public class BulletBuilder
    {
        private ObjectPooler objectPooler;

        private string poolTag = "Laser";

        private Quaternion rotation = Quaternion.identity;
        private Vector3 position;
        private Vector2 directionForce;
        
        public static BulletBuilder AsNewBullet => new BulletBuilder();

        private BulletBuilder()
        {
            objectPooler = Object.FindObjectOfType<ObjectPooler>();
        }


        public BulletBuilder WithPosition(Vector3 position)
        {
            this.position = position;
            return this;
        }

        public BulletBuilder WithRotation(Quaternion rotation)
        {
            this.rotation = rotation;
            return this;
        }

        public BulletBuilder WithForce(Vector2 directionForce)
        {
            this.directionForce = directionForce;
            return this;
        }


        public GameObject Build()
        {
            GameObject bullet = objectPooler.SpawnFromPool(poolTag, position, rotation);
            
            bullet.GetComponent<Rigidbody2D>()?.AddForce(directionForce, ForceMode2D.Impulse);

            return bullet;
        }
    }
}