// Import necessary libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Define the PauseMenu class
public class PauseMenu : MonoBehaviour
{
    // Variable to track whether the game is currently paused
    private bool isPaused;

    // Reference to the UI panel that will be activated when the game is paused
    public GameObject pausePanel;

    // Start is called before the first frame update
    void Start()
    {
        // Initialization code can be added here if needed
    }

    // Update is called once per frame
    void Update()
    {
        // Check for the "Pause" input button press
        if (Input.GetButtonDown("Pause"))
        {
            // If the game is already paused, resume it; otherwise, pause it
            if (isPaused)
                ResumeGame();
            else
                PauseGame();
        }
    }

    // Function to pause the game
    public void PauseGame()
    {
        // Set the time scale to 0, effectively pausing the game
        Time.timeScale = 0;

        // Activate the pause panel to display the pause menu
        pausePanel.SetActive(true);

        // Update the isPaused variable to true
        isPaused = true;
    }

    // Function to resume the game
    public void ResumeGame()
    {
        // Set the time scale back to 1 to resume normal game speed
        Time.timeScale = 1;

        // Deactivate the pause panel to hide the pause menu
        pausePanel.SetActive(false);

        // Update the isPaused variable to false
        isPaused = false;
    }
}
