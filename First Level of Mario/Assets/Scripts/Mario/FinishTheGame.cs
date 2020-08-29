using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTheGame : MonoBehaviour
{
    float speed = 2.5f;

    public Rigidbody2D rb;
    public BoxCollider2D finnishPoint;
    public GameObject camera;
    public AudioSource finishSound;


    private void Start()
    {
        finishSound.Play();
    }
    private void Update()
    {
        rb.transform.position = Vector2.MoveTowards(rb.transform.position, finnishPoint.transform.position, speed * Time.deltaTime);
        if(rb.transform.position.x <= 213)
        camera.transform.position = new Vector3(rb.transform.position.x, rb.transform.position.y, -10);
    }

}
