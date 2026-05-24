using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI textoScore;

    int score = 0;
    int highScore = 0;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    void Update()
    {
        score++;

        textoScore.text = "Score: " + score + "  HighScore: " + highScore;

        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }
}