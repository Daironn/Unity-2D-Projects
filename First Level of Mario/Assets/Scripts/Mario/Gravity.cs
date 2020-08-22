using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public float FallForce = 2.5f;
    public float lowJumpForce = 2f;


    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (FallForce - 1) * Time.deltaTime;
        }
        else if(rb.velocity.y > 0 && !Input.GetKey("up"))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpForce - 1) * Time.deltaTime;
        }
    }
}

