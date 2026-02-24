using System;
using UnityEngine;

public class FlappyBehaviour : MonoBehaviour
{
    [SerializeField] private float JumpForce = 1;

    private Rigidbody2D rigidbody;
    
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            rigidbody.linearVelocity += Vector2.up * JumpForce;
        }
    }
}

