using System;
using UnityEngine;

public class FlappyBehaviour : MonoBehaviour
{
    [SerializeField] private float JumpForce = 1;
    [SerializeField] private float rotationSpeed = 1;

    private Rigidbody2D rigidbody;
    
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            rigidbody.linearVelocity = Vector2.up * JumpForce;
        }

        transform.rotation = Quaternion.Euler(0f, 0f, rigidbody.linearVelocity.y * rotationSpeed);
    }
}

