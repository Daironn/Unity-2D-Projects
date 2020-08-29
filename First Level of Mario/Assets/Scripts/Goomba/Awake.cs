using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Awake : MonoBehaviour
{
    public GameObject player;
    private Transform transform;
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Math.Abs(player.transform.position.x - transform.position.x) < 20 && GetComponent<Walking>().enabled == false)
        {
            GetComponent<Walking>().enabled = true;
            Debug.Log("Walk!");
        }
        
    }

}
