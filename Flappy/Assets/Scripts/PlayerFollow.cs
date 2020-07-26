using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{


    public Transform playerTransform;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(playerTransform.position.x+2,transform.position.y, transform.position.z);
    }
}
