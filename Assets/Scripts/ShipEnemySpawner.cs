using UnityEngine;


public class ShipEnemySpawner : EnemyObjectFactory
{
    [SerializeField] private GameObject shipEnemy;

    protected override GameObject Prefab => shipEnemy;
}