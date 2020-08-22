using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaGravity : MonoBehaviour
{
    Rigidbody2D rb;

    float FallForce = 1;
    void Start()
    {
        rb = GetComponentInParent<Rigidbody2D>();
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Gravity");
        rb.velocity += Vector2.up * Physics2D.gravity.y * (FallForce - 1) * Time.deltaTime * 10;
        rb.gravityScale = 25;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Stop");
        rb.velocity += Vector2.up * 0;
        rb.gravityScale = 1;

    }
}
