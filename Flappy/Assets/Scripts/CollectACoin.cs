using System.Collections;
using System.Collections.Generic;

using UnityEngine;


public class CollectACoin : MonoBehaviour
{
    public int score = 0;

    public AudioSource collected;

    private void Start()
    {
        collected.volume = 0.1f;
    }
    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            score++;
            collected.Play();
            Destroy(collision.gameObject);
        }
    }
}
