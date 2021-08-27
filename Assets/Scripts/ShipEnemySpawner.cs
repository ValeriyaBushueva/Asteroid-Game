using UnityEngine;


    public class ShipEnemySpawner: MonoBehaviour
    {
        [SerializeField] private GameObject shipEnemy;
        [SerializeField] private float shipForce = 1000f;

        private void Start()
        {
            GameObject spawnShip = Instantiate(shipEnemy, new Vector3(Random.Range(-30.0f, 32.0f), Random.Range(-20.0f, 20.0f), 0), Quaternion.identity);
            Vector2 force = Random.insideUnitCircle * shipForce;
            spawnShip.GetComponent<Rigidbody2D>().AddForce(force);
        }
    }
