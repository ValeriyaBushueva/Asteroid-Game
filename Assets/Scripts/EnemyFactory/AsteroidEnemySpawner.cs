using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidEnemySpawner : EnemyObjectFactory
{
    [SerializeField] private List<GameObject> asteroidsEnemy = new List<GameObject>();
    
    protected override GameObject Prefab => asteroidsEnemy[Random.Range(0, asteroidsEnemy.Count)];
    
}
