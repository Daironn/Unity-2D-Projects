using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCoin : MonoBehaviour
{
    public Sprite empty;
    public Transform transform;
    public SpriteRenderer current;
    private void Start()
    {
        current = GetComponent<SpriteRenderer>();
        transform = GetComponent<Transform>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        current.sprite = empty;

    }
}
