using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    private Rigidbody2D rb;
    private Transform transform;
    private BoxCollider2D boxCol;

    public Walking walkingScript;


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("essa");
        }
        else
        {
            walkingScript.velocity *= -1;
        }
    }
}
