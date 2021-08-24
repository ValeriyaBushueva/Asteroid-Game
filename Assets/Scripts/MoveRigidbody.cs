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

        Vector2 maxInputMove = direction * speed;
        Vector2 velocityDifference = rigidbody.velocity - maxInputMove;

        
        
        if (velocityDifference <= speed)
        {
            rigidbody.AddForce(direction *acceleration * deltaTime, ForceMode2D.Impulse);
        }
    }
}