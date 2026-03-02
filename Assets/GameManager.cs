using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] TMP_Text gameOverText;
    [SerializeField] TMP_Text scoreText;

    int score = 0;
    bool isGameOver = false;

    void Awake()
    {
        instance = this;
        gameOverText.gameObject.SetActive(false);
        scoreText.text = "Score: 0";
    }

    public void AddScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        isGameOver = true;
        Time.timeScale = 0f;
        gameOverText.gameObject.SetActive(true);
    }

    void Update()
    {
        if (isGameOver && Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1f;
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}