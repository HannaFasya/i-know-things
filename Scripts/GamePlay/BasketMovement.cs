using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketMovement : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D basketBody;

    void Awake()
    {
        basketBody = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        Vector2 vel = basketBody.velocity;
        vel.x = Input.GetAxis("Horizontal") * speed;
        basketBody.velocity = vel;
    }
} // End
