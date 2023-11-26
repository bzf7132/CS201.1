// Import necessary libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Define the PlayerLives class
public class PlayerLives : MonoBehaviour
{
    // Public variable to represent the initial number of lives
    public int lives = 3;

    // Array to hold references to UI images representing player lives
    public Image[] livesUI;

    // Reference to the PointManager script for updating high scores
    public PointManager pointManager;

    // Start is called before the first frame update
    void Start()
    {
        // Initialization code can be added here if needed
    }

    // Update is called once per frame
    void Update()
    {
        // Update logic can be added here if needed
    }

    // OnCollisionEnter2D is called when the object collides with another object
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object has the tag "Enemy"
        if (collision.collider.gameObject.tag == "Enemy")
        {
            // Destroy the enemy object
            Destroy(collision.collider.gameObject);

            // Decrease the player's lives
            lives -= 1;

            // Update the UI to reflect the current number of lives
            UpdateLivesUI();

            // Check if the player has run out of lives
            if (lives <= 0)
            {
                // Destroy the player object
                Destroy(gameObject);

                // Call HighScoreUpdate method from PointManager script
                pointManager.HighScoreUpdate();
            }
        }
    }

    // OnTriggerEnter2D is called when the object's collider enters another collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collided object has the tag "Enemy Projectile"
        if (collision.gameObject.tag == "Enemy Projectile")
        {
            // Destroy the enemy projectile object
            Destroy(collision.gameObject);

            // Decrease the player's lives
            lives -= 1;

            // Update the UI to reflect the current number of lives
            UpdateLivesUI();

            // Check if the player has run out of lives
            if (lives <= 0)
            {
                // Destroy the player object
                Destroy(gameObject);

                // Call HighScoreUpdate method from PointManager script
                pointManager.HighScoreUpdate();
            }
        }
    }

    // Function to update the UI to reflect the current number of lives
    void UpdateLivesUI()
    {
        for (int i = 0; i < livesUI.Length; i++)
        {
            // Enable or disable UI images based on the current number of lives
            if (i < lives)
            {
                livesUI[i].enabled = true;
            }
            else
            {
                livesUI[i].enabled = false;
            }
        }
    }
}
