using UnityEngine;

internal class MoveRigidbody: IMove
{
   
    private Rigidbody2D rigidbody;
    private readonly float speed;
    private Vector3 direction;

    public MoveRigidbody(Rigidbody2D rigidbody, float speed)
    {
        this.rigidbody = rigidbody;
        this.speed = speed;
    }

    public float Speed { get; }
    public void Move(float horizontal, float vertical, float deltaTime)
    {
        rigidbody.AddForce(direction * speed, ForceMode2D.Impulse);
    }
}