using DefaultNamespace;
using UnityEngine;

public class BulletCollision : MonoBehaviour, IDamageStorage
{
    [SerializeField] private int damage;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }
    }

    public int Damage
    {
        get => damage;
        set => damage = value;
    }
}