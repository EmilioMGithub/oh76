using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 100;
    public float maxSpeed = 3;
    private Vector2 movementDir;

    void Start()
    {
        
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector2 combinedInput = new Vector2(horizontal, vertical);
        combinedInput.Normalize(); // Clamp input magnitude to 1

        movementDir = combinedInput * speed;
    }

    private void FixedUpdate()
    {
        rb.AddForce(movementDir);
        rb.velocity = Vector2.ClampMagnitude(rb.velocity, maxSpeed);
    }
}
