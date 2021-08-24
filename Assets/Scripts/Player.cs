using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal sealed class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float acceleration;
    [SerializeField] private float hp;
    [SerializeField] private Rigidbody2D bullet;
    [SerializeField] private Transform barrel;
    [SerializeField] private float force;
    private Camera camera;
    private Ship ship;

    private void Start()
    {
        camera = Camera.main;
        var moveTransform = new AccelerationMove(transform, speed, acceleration);
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
            var temAmmunition = Instantiate(bullet, barrel.position, barrel.rotation);
            temAmmunition.AddForce(barrel.up * force);
        }
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            hp--;
        }
    }
}