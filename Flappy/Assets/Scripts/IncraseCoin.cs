using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class IncraseCoin : MonoBehaviour
{
    public Text ScoreText;
    public CollectACoin Score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = Score.score.ToString();
    }
}
