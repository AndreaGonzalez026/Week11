using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Text scoreText;
    public GameObject titleScreen;
    public GameObject gameOverScreen;
    public GameObject gameplayUI;
    private int score;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void StartGame(int difficulty)
    {
        score = 0;
        scoreText.text = "Score: " + score;
        titleScreen.SetActive(false);
        gameplayUI.SetActive(true);
        // Adjust game settings based on difficulty
        ObjectSpawner spawner = FindObjectOfType<ObjectSpawner>();
        spawner.spawnInterval = 2f / difficulty;
    }

    public void AddScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        gameplayUI.SetActive(false);
        gameOverScreen.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
