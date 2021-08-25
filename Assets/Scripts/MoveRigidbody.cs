using UnityEngine;

internal class MoveRigidbody : IMove
{
    private Rigidbody2D rigidbody;
    private readonly float speed;
    private readonly float acceleration;
    private Vector3 direction;

    public MoveRigidbody(Rigidbody2D rigidbody, float speed, float acceleration)
    {
        this.rigidbody = rigidbody;
        this.speed = speed;
        this.acceleration = acceleration;
    }

    public float Speed { get; }

    public void Move(float horizontal, float vertical, float deltaTime)
    {
        direction = new Vector2(horizontal, vertical).normalized;

        rigidbody.AddForce(direction * acceleration * deltaTime, ForceMode2D.Impulse);
        
        rigidbody.velocity = Vector2.ClampMagnitude(rigidbody.velocity, speed);
    }
}