using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform transform;
 
    public GameObject player;
    public GameObject leftWall;
    void Start()
    {
        transform = GetComponent<Transform>();
        rb = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.x > 0 && player.transform.position.x > transform.position.x)
        {
            transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
            leftWall.transform.position = new Vector3(transform.position.x - 14.9f, leftWall.transform.position.y, leftWall.transform.position.z);
        }
        transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
    }
}
