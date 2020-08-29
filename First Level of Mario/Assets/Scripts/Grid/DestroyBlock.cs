using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlock : MonoBehaviour
{
    public GameObject Block;
    public GameObject BrickParticle;
    public GameObject CoinParticle;


    public AudioSource breakSound;
    public AudioSource coinSound;

    private MariosForm Form;

    public int brickHealth = 0;
    private void Start()
    {
        Form = GameObject.FindGameObjectWithTag("Player").GetComponent<MariosForm>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Form.GetState() != 0 && brickHealth == 0)
            {
                Instantiate(BrickParticle, new Vector3(transform.position.x, transform.position.y - 2, transform.position.z), Quaternion.identity);
                breakSound.Play();
                Destroy(Block);
            }
            else if(brickHealth > 0 && Form.GetState() != 0)
            {
                coinSound.Play();
                Instantiate(CoinParticle, new Vector3(transform.position.x, transform.position.y - 2, transform.position.z), Quaternion.identity);
                brickHealth--;
            }
        }

    }
}
