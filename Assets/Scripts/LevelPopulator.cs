using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class LevelPopulator : MonoBehaviour
{
    [SerializeField] private EnemyObjectFactory enemyFactory;
    [SerializeField] private EnemyObjectFactory asteroidFactory;

    [SerializeField] private int asteroidAmount = 5;
    [SerializeField] private float asteroidForce = 100;
    [SerializeField] private float enemyForce = 400;
    
    private void Start()
    {
        CreateAsteroids();

        CreateEnemyShip();
    }

    private void CreateAsteroids()
    {
        for (int i = 0; i < asteroidAmount; i++)
        {
            GameObject asteroid = asteroidFactory.Create();

            ApplyForceToObject(asteroid, asteroidForce);
        }
    }

    private void CreateEnemyShip()
    {
        GameObject enemyShip = enemyFactory.Create();

        ApplyForceToObject(enemyShip, enemyForce);
    }

    private void ApplyForceToObject(GameObject enemyObject, float force)
    {
        Vector2 directionForce = Random.insideUnitCircle * force;
        enemyObject.GetComponent<Rigidbody2D>().AddForce(directionForce);
    }
}