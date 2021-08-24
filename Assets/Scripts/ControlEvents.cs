using System;
using UnityEngine;

public class ControlEvents: MonoBehaviour
    {
        public event Action Fire;
        public event Action<Vector2> MoveAxis;
       
        public void FixedUpdate()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            MoveAxis?.Invoke(new Vector2(horizontal, vertical));

            if (Input.GetButtonDown("Fire1"))
            {
                Fire?.Invoke();
            }
        }
    }
