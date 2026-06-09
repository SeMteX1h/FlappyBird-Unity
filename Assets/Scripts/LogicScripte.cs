using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScripte : MonoBehaviour
{
    public int PlayerScore;
    public Text ScoreText;
    public GameObject gameOverScreen;
    public bool gameIsOver = false;

    [ContextMenu("increase Score")]
    public void addScore()
    {
        PlayerScore = PlayerScore + 1;
        ScoreText.text = PlayerScore.ToString();
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameIsOver = true;
        gameOverScreen.SetActive(true);
    }
    public void quit()
    {
        Application.Quit();
        Debug.Log("Game Closed");
    }
    

}