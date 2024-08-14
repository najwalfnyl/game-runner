using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartRun : MonoBehaviour
{
    public GameObject coinDisplay;
    public GameObject distanceDisplay;
    public GameObject pauseMenu;
    public GameObject mainMenu;
    public GameObject playButton;
    public AudioSource DesertBGM; // Reference to the AudioSource component

    void Start()
    {
        // Initial setup
        coinDisplay.SetActive(false);
        distanceDisplay.SetActive(false);
        pauseMenu.SetActive(false);
        mainMenu.SetActive(true);
        Time.timeScale = 0f; // Pause the game

        // Mute the background music at the start
        if (DesertBGM != null)
        {
            DesertBGM.volume = 0f;
            DesertBGM.Play();
        }
    }

    public void PlayButtonClicked()
    {
        // Activate coin and distance displays
        coinDisplay.SetActive(true);
        distanceDisplay.SetActive(true);
        pauseMenu.SetActive(true);

        // Deactivate main menu and play button
        mainMenu.SetActive(false);
        playButton.SetActive(false);

        // Unpause the game
        Time.timeScale = 1f;

        // Turn on the background music
        if (DesertBGM != null)
        {
            DesertBGM.volume = 0.1f;
        }
    }
}
