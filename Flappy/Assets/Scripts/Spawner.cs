using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Prefab;
    public GameObject Player;

    public bool spawn = true;
    public float RespawnTime = 1f;

    private Vector2 ScreenBounds = new Vector2(2f,-3.5f);


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(pipes());
    }

    // Update is called once per frame
    void Update()
    {
        //spawnPipe();
    }
    private void spawnPipe()
    {
        GameObject pipe = Instantiate(Prefab) as GameObject; //Tworzy kopie obiektu i ustawia go jako GameObject
        pipe.transform.position = new Vector2(Player.transform.position.x +20, Random.Range(ScreenBounds.x, ScreenBounds.y));
    }
    IEnumerator pipes()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(RespawnTime);
            spawnPipe();
        }
    }
}
