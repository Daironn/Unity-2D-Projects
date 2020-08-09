using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    public Rigidbody2D rb;
    public float velocity = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(velocity, 0 , 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(rb.transform.position.x > collision.gameObject.transform.position.x || rb.transform.position.x < collision.gameObject.transform.position.x)
        {
            velocity = -velocity;
        }

    }
}
