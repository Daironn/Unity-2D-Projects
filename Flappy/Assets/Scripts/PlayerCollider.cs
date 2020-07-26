using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    public Spawner spawner;
    public Movement movement;

    public AudioSource dieSound;
    public AudioSource collisionSound;


    bool playedOnce = false;

    public float volume = 0.3f;

    private void Start()
    {
        collisionSound.volume = volume;
        dieSound.volume = volume - 0.1f;
    }
    void OnCollisionEnter2D(Collision2D info)
    {
        if (info.gameObject.tag != "Coin")
        {
            dead();

            if (playedOnce == false)
            {
                playSound();
            }
        }

    }
    private void dead()
    {
        movement.enabled = false;
        spawner.spawn = false;
        this.enabled = false;
        movement.body.velocity = new Vector3(0, 0, 0);
    }

    private void playSound()
    {
        collisionSound.Play();
        dieSound.Play();
        playedOnce = true;
    }
}
