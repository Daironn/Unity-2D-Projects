using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GainACoin : MonoBehaviour
{
    public AudioSource coinSound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggered");
        Destroy(this.gameObject);
        coinSound.Play();
    }
}
