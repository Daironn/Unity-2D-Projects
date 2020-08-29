using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime;
using System;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool isJumping = false;

    enum Move {Left,Right,Jump, NULL};
    Move VerticalMove;
    Move HorisontalMove;

    public float height = 15f;

    public GameObject JumpParticle;
    public AudioSource JumpSound;
    public AudioSource poleSound;

    public Animator animator; 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        FixedMovement();
    }
    private void Update()
    {
        if (Input.GetKey("right"))
        {

            if (Math.Abs(rb.velocity.x) < 12)
                VerticalMove = Move.Left;
        }
        if (Input.GetKey("left"))
        {
            if (Math.Abs(rb.velocity.x) < 12)
                VerticalMove = Move.Right;

        }
        if (Input.GetKeyDown("up") && isJumping == false)
        {
            HorisontalMove = Move.Jump;
            Instantiate(JumpParticle, rb.transform.position, Quaternion.identity);
            JumpSound.Play();
        }
        animator.SetFloat("Speed",Math.Abs(rb.velocity.x));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Finnish")
        {
            rb.velocity = new Vector3(0, 0, 0);
            poleSound.Play();
            Invoke("DelayFinnish", 0.7f);
            this.enabled = false;
        }
    }
    private void DelayFinnish()
    {
        GetComponent<FinishTheGame>().enabled = true;
    }
    void FixedMovement()
    {
        if (VerticalMove == Move.Left)
        {
            rb.AddForce(new Vector2(25, 0f));
        }
        if (VerticalMove == Move.Right)
        {
            rb.AddForce(new Vector2(-25f, 0f));
        }
        if(HorisontalMove == Move.Jump)
        {
            rb.AddForce(new Vector2(0f, height * 75f));

        }

        VerticalMove = Move.NULL;
        HorisontalMove = Move.NULL;
    }


}
