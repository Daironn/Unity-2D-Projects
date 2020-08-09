using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbleToJump : MonoBehaviour
{
    public GameObject Player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Player.GetComponent<Movement>().isJumping = false;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Player.GetComponent<Movement>().isJumping = true;
    }
}
