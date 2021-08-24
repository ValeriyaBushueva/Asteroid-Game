using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal sealed class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float acceleration;
    [SerializeField] private ControlEvents controlEvents;
    [SerializeField] private InstantiateBullet instantiateBullet;
    
    private Ship ship;
    private IMove move;
    private IRotation rotation;


    private void Start()
    {
        Rigidbody2D rigidBody = GetComponent<Rigidbody2D>();
        move = new MoveRigidbody(rigidBody, speed, acceleration);
        rotation = new RotationShip(transform);
        
        ship = new Ship(move, rotation);


        controlEvents.Fire += instantiateBullet.BulletSpawn;

        controlEvents.MoveAxis += Move;
    }

    private void Move(Vector2 axis)
    {
        move.Move(axis.x, axis.y, Time.deltaTime);
    }
}