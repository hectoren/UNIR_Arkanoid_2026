using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public int score = 0;
    public TextMeshProUGUI scoreText;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        UpdateScoreUI();
        InvokeRepeating("DecreaseScore", 1f, 1f);
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreUI();
    }

    void DecreaseScore()
    {
        score -= 1;
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score;
    }
}
