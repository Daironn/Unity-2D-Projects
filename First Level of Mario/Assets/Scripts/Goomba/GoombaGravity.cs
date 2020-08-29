using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaGravity : MonoBehaviour
{
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponentInParent<Rigidbody2D>();
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        rb.gravityScale = 40;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.gravityScale = 1;
    }
}
