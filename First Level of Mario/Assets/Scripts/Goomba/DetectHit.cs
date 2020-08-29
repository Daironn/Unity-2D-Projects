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

    public AudioSource [] stopSound;


    private void Start()
    {
        rb = Goomba.GetComponent<Rigidbody2D>();
        boxCol = GetComponent<BoxCollider2D>();
        transform = Goomba.GetComponent<Transform>();
        stopSound = GameObject.FindGameObjectWithTag("MainCamera").GetComponents<AudioSource>();

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            boxCol.enabled = false;
            walkingScript.velocity = 0;
            transform.localScale = new Vector3(1, 0.5f, 1);

            stopSound[1].Play();
            stopSound[2].Play();

            Invoke("Destroy", 0.5f);
        }
    }
    private void Destroy()
    {
        Destroy(Goomba.gameObject);
    }
}
