using System;
using UnityEngine;
using UnityEngine.SpatialTracking;
using Object = UnityEngine.Object;

namespace DefaultNamespace
{
    public class BulletBuilder
    {
        private IObjectPool objectPooler;

        private static IServiceLocator serviceLocator;

        private string poolTag = "Laser";

        private Quaternion rotation = Quaternion.identity;
        private Vector3 position;
        private Vector2 directionForce;
        private int damage;

        private BulletBuilder()
        {
            objectPooler = serviceLocator.Get<IObjectPool>();
        }

        public static BulletBuilder AsNewBullet()
        {
            if (serviceLocator == null)
            {
                throw new InvalidOperationException("Service locator not injected!");
            }
            return new BulletBuilder();
        }

        public static void InjectServiceLocator(IServiceLocator serviceLocator)
        {
            BulletBuilder.serviceLocator = serviceLocator;
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
        
        public BulletBuilder WithDamage(int damage)
        {
            this.damage = damage;
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

            bullet.GetComponent<IDamageStorage>().Damage = damage;
            bullet.GetComponent<Rigidbody2D>()?.AddForce(directionForce, ForceMode2D.Impulse);

            return bullet;
        }
    }
}