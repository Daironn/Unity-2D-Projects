using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterHiddenArea : MonoBehaviour
{
    bool inArea = false;
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
        if (inArea && Input.GetKeyDown("down"))
        {
            Debug.Log("Entered");
            SceneManager.LoadScene("HiddenLevel");
        }
    }
}
