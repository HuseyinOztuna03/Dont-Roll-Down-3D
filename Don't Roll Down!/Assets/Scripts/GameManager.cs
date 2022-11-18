using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{ 
    public Text Title;
    public Text Credits;
    public Text ScoreText;
    public Text HighScoreText;
    public Image GameOverScene;
    public GameObject StartButton;
    
    void Start()
    {
        Ball.fall = false;
        Time.timeScale = 0f;
        ScoreText.gameObject.SetActive(false);
        HighScoreText.gameObject.SetActive(true);
    }
    private void Update()
    {
        if (Ball.fall == true)
        {
            GameOverScene.gameObject.SetActive(true);
            StartCoroutine(GameOver());
        }
    }
    public void StartGame()
    {
        Title.gameObject.SetActive(false);
        Credits.gameObject.SetActive(false);
        ScoreText.gameObject.SetActive(true);
        HighScoreText.gameObject.SetActive(false);
        //HighScoreText.gameObject.SetActive(false);
        Time.timeScale = 1f;
        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
    IEnumerator GameOver()
    {
        StartButton.gameObject.SetActive(false);
        HighScoreText.gameObject.SetActive(true);
        yield return new WaitForSeconds(3f);
        Time.timeScale = 0f;
    }
}
