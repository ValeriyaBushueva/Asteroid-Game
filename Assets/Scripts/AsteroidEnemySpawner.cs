using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidEnemySpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> asteroidsEnemy = new List<GameObject>();
    [SerializeField] private int enemyAmount = 3;
    [SerializeField] private float force = 2000;
    
    
    private Vector2 spawnPosition;
    void Start()
    {
         for (int i = 0; i < enemyAmount; i++)
         {
             
            GameObject asteroid = Instantiate(asteroidsEnemy[Random.Range(0,asteroidsEnemy.Count)], new Vector3(Random.Range(-30.0f, 32.0f), Random.Range(-20.0f, 20.0f), 0), Quaternion.identity);
            Vector2 force = Random.insideUnitCircle * this.force;
            asteroid.GetComponent<Rigidbody2D>().AddForce(force);

         }
    }
    
    

  
}
