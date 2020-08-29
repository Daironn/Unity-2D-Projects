using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterHiddenArea : MonoBehaviour
{
    bool inArea = false;

    static int ExitIndex = 0;

    private AudioSource EnterPipe;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        inArea = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        inArea = false;
    }
    private void Update()
    {

        if (inArea && Input.GetKeyDown("space"))
        {
            Debug.Log("Entered");
            if (SceneManager.GetActiveScene().name == "MainLevel")
            {
                SceneManager.LoadScene("HiddenLevel");

            }
            else if (SceneManager.GetActiveScene().name == "HiddenLevel")
            {
                SceneManager.LoadScene("MainLevel");
                ExitIndex++;
            }
            EnterPipe.Play();
        }
    }
    private void Start()
    {
        EnterPipe = GetComponent<AudioSource>();

        if(ExitIndex != 0)
        {
            Debug.Log("Halo");
            Vector3 position = GameObject.FindGameObjectWithTag("Exit").transform.position;
            GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(position.x, position.y + 2, position.z);
        }
    }
}
