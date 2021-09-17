using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class JsonEnemyLoadFactory : MonoBehaviour, IEnemyFactory
{
    [SerializeField] private TextAsset jsonEnemyData;

    [SerializeField] private EnemyPrefabByType[] enemyPrefabs;

    [SerializeField] private EnemyDataProtocolCollection enemyDataCollection;

    public GameObject Create()
    {
        LoadData();

        GameObject parent = new GameObject("Json enemy parent");

        foreach (var enemyData in enemyDataCollection.enemyData.Select(x => x.unit))
        {
            Instantiate(enemyPrefabs.First(x => x.Type == enemyData.type).EnemyPrefab, parent.transform);
        }

        return parent;
    }

    private void LoadData()
    {
        JsonUtility.FromJsonOverwrite("{\"enemyData\": " + jsonEnemyData.text + "}", enemyDataCollection);
    }
}