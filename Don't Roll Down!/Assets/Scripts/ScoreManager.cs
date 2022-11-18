using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    public static int high_score;
    public Text ScoreText;
    public Text HighScoreText;
    void Start()
    {
        ScoreText.gameObject.SetActive(false);
        score = 0;
        //PlayerPrefs.DeleteAll();
    }

    void Update()
    {
        HighScoreText.text = high_score.ToString();
        ScoreText.text = score.ToString();
        if (score > PlayerPrefs.GetInt("high_score"))
        {
            PlayerPrefs.SetInt("high_score", score);
        }
        HighScoreText.text = "Highest: " + PlayerPrefs.GetInt("high_score").ToString();
    }
}
