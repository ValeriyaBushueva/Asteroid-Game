using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class MoveTransform : IMove
{
    private readonly Transform transform;
    private readonly float speed;
    private Vector3 move;

    public MoveTransform(Transform transform, float speed)
    {
        this.transform = transform;
        this.speed = speed;
    }

    public float Speed { get; protected set; }

    public void Move(float horizontal, float vertical, float deltaTime)
    {
        var speed = deltaTime * this.speed;
         move.Set(horizontal * speed, vertical * speed, 0.0f);
        transform.localPosition += move;
    }
}
