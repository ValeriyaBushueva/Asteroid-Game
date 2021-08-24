﻿using UnityEngine;

    public class PlayerCollisionDeath
    {   
        [SerializeField] private float hp;

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (hp <= 0)
            {
               // Destroy(gameObject);
            }
            else
            {
                hp--;
            }
        }
        
    }
