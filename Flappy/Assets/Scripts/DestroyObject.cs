using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    private float LeftEdge;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        LeftEdge = player.transform.position.x - 8;

        if (transform.position.x < LeftEdge)
        {
            Destroy(this.gameObject);
        }
    }
}
