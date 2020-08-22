using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlock : MonoBehaviour
{
    public GameObject Block;
    public GameObject Particle;


    public AudioSource breakSound;

    private void Start()
    {
        //Block = GetComponentInParent<GameObject>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Instantiate(Particle, new Vector3(transform.position.x, transform.position.y - 2, transform.position.z), Quaternion.identity);
            breakSound.Play();
            Destroy(Block);
        }

    }
}
