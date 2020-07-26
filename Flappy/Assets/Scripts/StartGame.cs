using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public Movement movement;
    public Spawner spawner;
    public IncraseCoin incCoin;
    public Text Text;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        ChangeTheState(false);
        Text.text = "Press space to start the game!";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeTheState(true);
        }
    }

    void ChangeTheState(bool state)
    {
        movement.enabled = state;
        spawner.enabled = state;
        incCoin.enabled = state;
        rb.simulated = state;
    }
}

