using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D boxCol;
    private Transform transform;
    public Walking walkingScript;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        boxCol = GetComponent<BoxCollider2D>();
        transform = GetComponent<Transform>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
 
        if (rb.transform.position.y + 0.5f < collision.gameObject.transform.position.y - 0.5f && collision.gameObject.CompareTag("Player"))
        {
            boxCol.enabled = false;
            transform.localScale = new Vector3(1, 0.5f, 1);
            walkingScript.velocity = 0;
            Invoke("Destroy", 0.5f);
        }
    }
    private void Destroy()
    {
        Destroy(this.gameObject);
    }
}
