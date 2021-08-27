using UnityEngine;

public abstract class EnemyObjectFactory : MonoBehaviour
{
    [SerializeField] private float minHorizontal = -30.0f;
    [SerializeField] private float maxHorizontal = 32.0f;
    [SerializeField] private float minVertical = -20.0f;
    [SerializeField] private float maxVertical = 20.0f;

    protected abstract GameObject Prefab { get; }

    public GameObject Create()
    {
        float randomX = Random.Range(minHorizontal, maxHorizontal);
        float randomY = Random.Range(minVertical, maxVertical);

        Vector3 position = new Vector3(randomX, randomY, 0);

        return Instantiate(Prefab, position, Quaternion.identity);
    }
}