using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public int Score = 0;
    public TMP_Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Score);
    }
    public void ScoreIncrement()
    {
        Score = Score + 1;
        ScoreText.text = Score.ToString();
        //ebug.Log(Score); 
    }

}
