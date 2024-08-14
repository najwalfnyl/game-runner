using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject pausePanel;
    public Button pauseButton;
    public Button resumeButton; // Add a reference to your "Resume" button
    public Button restartButton; // Add a reference to your "Restart" button

    private bool isPaused = false;

    void Start()
    {
        // Ensure the pause panel is initially inactive
        if (pausePanel != null)
        {
            pausePanel.SetActive(false);
        }

        // Attach the button click events
        if (pauseButton != null)
        {
            pauseButton.onClick.AddListener(TogglePause);
        }

        if (resumeButton != null)
        {
            resumeButton.onClick.AddListener(ResumeGame);
            resumeButton.gameObject.SetActive(false); // Initially hide the "Resume" button
        }

        if (restartButton != null)
        {
            restartButton.onClick.AddListener(RestartGame);
        }
    }

    void Update()
    {
        // Check for the "Esc" key to toggle pause
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            // Pause the game
            Time.timeScale = 0f;

            // Show the pause panel and "Resume" button
            if (pausePanel != null && resumeButton != null)
            {
                pausePanel.SetActive(true);
                resumeButton.gameObject.SetActive(true);
            }
        }
        else
        {
            // Unpause the game
            Time.timeScale = 1f;

            // Hide the pause panel and "Resume" button
            if (pausePanel != null && resumeButton != null)
            {
                pausePanel.SetActive(false);
                resumeButton.gameObject.SetActive(false);
            }
        }
    }

    void ResumeGame()
    {
        TogglePause(); // Call the same method to resume the game
    }

    void RestartGame()
    {
        // Reload the current scene to restart the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
