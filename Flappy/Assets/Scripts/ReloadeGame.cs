using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadeGame : MonoBehaviour
{
    public Spawner state;
    public IncraseCoin info;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(state.spawn == false)
        {
            info.enabled = false;
            info.ScoreText.text = "Your score is: "+info.Score.score.ToString() + "\n\n Press SPACE to restart the game";
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Invoke("Restart", 0f); //Just to keep that in mind, it is useless here
            }
        }
    }
    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
