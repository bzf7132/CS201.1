// Import necessary libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Define the PointManager class
public class PointManager : MonoBehaviour
{
    // Public variable to store the current score
    public int score;

    // Reference to the TextMeshProUGUI component for displaying the score
    public TextMeshProUGUI scoreText;

    // References to TextMeshProUGUI components for displaying the final score and high score
    public TMP_Text finalScoreText;
    public TMP_Text highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        // Set the initial score text on start
        scoreText.text = "Score: " + score;
    }

    // Function to update the score and display it
    public void UpdateScore(int points)
    {
        // Update the score by adding the given points
        score += points;

        // Update the score text to reflect the new score
        scoreText.text = "Score: " + score;
    }

    // Function to update the high score
    public void HighScoreUpdate()
    {
        // Check if there is already a saved high score
        if (PlayerPrefs.HasKey("SavedHighScore"))
        {
            // Compare the current score with the saved high score
            if (score > PlayerPrefs.GetInt("SavedHighScore"))
            {
                // Set a new high score if the current score is higher
                PlayerPrefs.SetInt("SavedHighScore", score);
            }
        }
        else
        {
            // Set the current score as the initial high score if there is no saved high score
            PlayerPrefs.SetInt("SavedHighScore", score);
        }

        // Update the TextMeshPro components to display the final score and high score
        finalScoreText.text = score.ToString();
        highScoreText.text = PlayerPrefs.GetInt("SavedHighScore").ToString();
    }
}
