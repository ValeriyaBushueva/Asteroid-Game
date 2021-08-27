using UnityEngine;

public class MoveOverScreen: MonoBehaviour
{
    [SerializeField] private float minHorizontal;
    [SerializeField] private float maxHorizontal;
    [SerializeField] private float minVertical;
    [SerializeField] private float maxVertical;

    private void Update()
    {
        if (transform.position.y > maxVertical)
        {
            transform.position = new Vector3(transform.position.x, minVertical);
        }

        if (transform.position.x > maxHorizontal)
        {
            transform.position = new Vector3(minHorizontal, transform.position.y);
        }

        if (transform.position.y < minVertical)
        {
            transform.position = new Vector3(transform.position.x, maxVertical);
        }

        if (transform.position.x < minHorizontal)
        {
            transform.position = new Vector3(maxHorizontal, transform.position.y);
        }
    }
}
    

        