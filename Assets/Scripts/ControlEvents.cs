using System;
using UnityEngine;using UnityEngine.Animations;

public class ControlEvents: MonoBehaviour
    {
        public event Action Fire;
        public event Action<Vector2> MoveAxis;
        public event Action<Vector2, float> MoveAxis2;
       
        public void Update()
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
