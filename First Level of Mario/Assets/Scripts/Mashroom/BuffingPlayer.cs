using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffingPlayer : MonoBehaviour
{
    private Walking walkingScript;
    private AudioSource [] BuffSound;
    public GameObject Mashroom;


    public MariosForm Mario;
    // Start is called before the first frame update
    void Start()
    {
        walkingScript = GetComponentInParent<Walking>();
        BuffSound = GameObject.FindGameObjectWithTag("Player").GetComponents<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Player")
        {
            walkingScript.velocity *= -1;
        }
        else
        {
            Destroy(Mashroom);
            GameObject.FindGameObjectWithTag("Player").GetComponent<MariosForm>().IncraseState();
            BuffSound[2].Play();
        }
    }
}
