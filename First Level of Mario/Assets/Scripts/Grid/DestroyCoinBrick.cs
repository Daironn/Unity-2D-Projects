using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCoinBrick : MonoBehaviour
{
    public float AmountOfCoins = 5;
    public GameObject Brick;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (AmountOfCoins == 0)
        {
            Destroy(Brick);
        }
        else
        {
            AmountOfCoins--;
            Debug.Log(AmountOfCoins);
        }
    }
}
