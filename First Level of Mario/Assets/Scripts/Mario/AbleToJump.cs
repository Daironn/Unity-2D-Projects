using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbleToJump : MonoBehaviour
{
    public GameObject Player;
    public Animator animator;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player.GetComponent<Movement>().isJumping = false;
        animator.SetBool("InAir", false);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Player.GetComponent<Movement>().isJumping = true;
        Debug.Log("AIR");
        animator.SetBool("InAir", true);
    }
}
