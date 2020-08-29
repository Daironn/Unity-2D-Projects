using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyQuestioBrick : MonoBehaviour
{

    public SpriteRenderer sr;
    public Sprite newSprite;
    public AudioSource ShroomAppear;

    public GameObject Mashroom;
    public BoxCollider2D spawnPosition;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            sr.sprite = newSprite;
            ShroomAppear.Play();
            Instantiate(Mashroom, spawnPosition.transform.position, Quaternion.identity);
            this.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
        }
    }
}
