using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;

    public TMP_Text finalScoreText;
    public TMP_Text highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score;
    }

    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }

    public void HighScoreUpdate()
    {
        // Is there already a highscore?
        if (PlayerPrefs.HasKey("SavedHighScore"))
        {
            if (score > PlayerPrefs.GetInt("SavedHighScore"))
            {  // Set new high score
                PlayerPrefs.SetInt("SavedHighScore", score);
            }
        }
        else
        {
            // if no highscore
            PlayerPrefs.SetInt("SavedHighScore", score);
        }

        // Updating TMP
        finalScoreText.text = score.ToString();
        highScoreText.text = PlayerPrefs.GetInt("SavedHighScore").ToString();
    }
}
