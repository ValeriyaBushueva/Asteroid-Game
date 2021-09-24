using System.Collections;
using UnityEngine;

public sealed class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float acceleration;
    [SerializeField] private ControlEvents controlEvents;
    [SerializeField] private InstantiateBullet instantiateBullet;
    [SerializeField] private Transform mouseTarget;
    [SerializeField] private PlayerModificationComposite modifications;
    
    private IMove move;
    private IRotation rotation;
    
    public float Speed
    {
        get => speed;
        set => speed = value;
    }

    public float Acceleration
    {
        get => acceleration;
        set => acceleration = value;
    }

    private void Start()
    {
        Rigidbody2D rigidBody = GetComponent<Rigidbody2D>();
        move = new MoveRigidbody(rigidBody, speed, acceleration);
        rotation = new RotationShip(transform);
        
        controlEvents.Fire += OnFire;

        controlEvents.MoveAxis += Move;
    }

    public void ApplyModifications()
    {
        modifications.Handle();
    }

    public void DiscourageModifications()
    {
        modifications.Unhandle();
    }

    private void Update()
    {
        Vector3 direction = mouseTarget.position - transform.position;
        direction.Normalize();
        
        rotation.Rotation(direction);
    }

    private void Move(Vector2 axis)
    {
        move.Move(axis.x, axis.y, Time.deltaTime);
    }

    private void OnFire()
    {
        Cursor.lockState = CursorLockMode.Locked;
        instantiateBullet.BulletSpawn();

        StartCoroutine(UnlockCursor());
    }


    private IEnumerator UnlockCursor()
    {
        yield return new WaitForSeconds(1);

        Cursor.lockState = CursorLockMode.None;
    }
}