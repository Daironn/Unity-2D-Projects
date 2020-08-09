﻿using System.Collections;
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

            if (Math.Abs(rb.velocity.x) < 10)
                VerticalMove = Move.Left;
        }
        if (Input.GetKey("left"))
        {
            if (Math.Abs(rb.velocity.x) < 10)
                VerticalMove = Move.Right;

        }
        if (Input.GetKeyDown("up") && isJumping == false)
        {
            HorisontalMove = Move.Jump;
        }

    }
    void FixedMovement()
    {
        if (VerticalMove == Move.Left)
        {
            rb.AddForce(new Vector2(19, 0f));
        }
        if (VerticalMove == Move.Right)
        {
            rb.AddForce(new Vector2(-19f, 0f));
        }
        if(HorisontalMove == Move.Jump)
        {
            rb.velocity = Vector2.up * height;
        }

        VerticalMove = Move.NULL;
        HorisontalMove = Move.NULL;
    }

}