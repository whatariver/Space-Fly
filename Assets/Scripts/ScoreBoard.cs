using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    public GameObject failtext;
    public int Score;
    public int HighScore;
    
    // Start is called before the first frame update
    void Start()
    {
        HighScore = PlayerPrefs.GetInt("HighScore");
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = Score.ToString();
        failtext.GetComponent<TextMeshProUGUI>().text = Score.ToString();
        if (Score > HighScore)
        {
            PlayerPrefs.SetInt("HighScore", Score);
        }
    }
}
