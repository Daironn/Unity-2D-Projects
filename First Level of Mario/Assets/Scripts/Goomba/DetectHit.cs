using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectHit : MonoBehaviour
{
    private Rigidbody2D rb;
    private Transform transform;
    private BoxCollider2D boxCol;

    public GameObject Goomba;
    public Walking walkingScript;

    private void Start()
    {
        rb = Goomba.GetComponent<Rigidbody2D>();
        boxCol = GetComponent<BoxCollider2D>();
        transform = Goomba.GetComponent<Transform>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            boxCol.enabled = false;
            Goomba.GetComponent<BoxCollider2D>().enabled = false;
            transform.localScale = new Vector3(1, 0.5f, 1);
            walkingScript.velocity = 0;
            Invoke("Destroy", 0.5f);
        }
    }
    private void Destroy()
    {
        Destroy(Goomba.gameObject);
    }
}
