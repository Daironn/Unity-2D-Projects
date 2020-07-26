using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D body;

    public float height = 10f;
    public float speed = 0.5f;
    public float volume = 0.5f;

    public AudioSource wing;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();

        body.AddForce(new Vector3(speed*500, 0, 0));
        wing.volume = volume;
    }

    // Update is called once per frame
    void Update()
    {
        if(body.velocity.x < 6)
        body.AddForce(new Vector3(speed, 0, 0));

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            body.AddForce(Vector2.up * height);
            wing.Play();
        }

    }
}
