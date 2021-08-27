using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> asteroidsEnemy = new List<GameObject>();
    [SerializeField] private int enemyAmount = 3;
    
    private Vector2 spawnPosition;
    void Start()
    {
         for (int i = 0; i < enemyAmount; i++)
         {

             
             Instantiate(asteroidsEnemy[Random.Range(0,asteroidsEnemy.Count)], new Vector3(Random.Range(-30.0f, 32.0f), Random.Range(-20.0f, 20.0f), 0), Quaternion.identity);
         }
    }

  
}
