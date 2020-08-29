using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GainACoin : MonoBehaviour
{
    public AudioSource coinSound;
    public GameObject coinParticle;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(coinParticle, transform.position, Quaternion.identity);
        coinSound.Play();
        Destroy(this.gameObject);

    }
}
