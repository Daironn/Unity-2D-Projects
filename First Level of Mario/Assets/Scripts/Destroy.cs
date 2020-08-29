using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Destroy : MonoBehaviour
{
    public Transform transform;
    Tilemap tilemap;
    public GameObject tilemapGameObject;

    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
        tilemap = tilemapGameObject.GetComponent<Tilemap>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector3 hitPosition = Vector3.zero;
        if (collision.gameObject.tag == "Player")
        {

            foreach (ContactPoint2D hit in collision.contacts)
            {
                hitPosition.x = hit.point.x - 0.01f * hit.normal.x;
                hitPosition.y = hit.point.y - 0.01f * hit.normal.y;

                if(hitPosition.y > collision.gameObject.transform.position.y) { 
                    Debug.Log("HIT");
                    tilemap.SetTile(tilemap.WorldToCell(hitPosition), null);
                }
            }
        }
    }
}
