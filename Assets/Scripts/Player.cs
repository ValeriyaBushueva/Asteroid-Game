using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal sealed class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float acceleration;
    [SerializeField] private float hp;
    private Camera camera;
    private Ship ship;
    private InstantiateBullet instantiateBullet;
    [SerializeField] private ControlEvents controlEvents;

    private void Start()
    {
        camera = Camera.main;
        Rigidbody2D rigidBody = GetComponent<Rigidbody2D>();
        var moveTransform = new MoveRigidbody(rigidBody, speed);
        var rotation = new RotationShip(transform);
        ship = new Ship(moveTransform, rotation);
        
    }

    private void Update()
    {
        var direction = Input.mousePosition - camera.WorldToScreenPoint(transform.position);
        ship.Rotation(direction);

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        ship.Move(horizontal, vertical, Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            ship.AddAcceleration();
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            ship.RemoveAcceleration();
        }

        if (Input.GetButtonDown("Fire1"))
        {
            instantiateBullet.BulletSpawn();
        }
        
    }
   
}