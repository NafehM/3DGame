using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // Load the scene that starts the game
        SceneManager.LoadScene("GameScene");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Options()
    {
        Debug.Log("Open Options");
    }

    public void QuitGame()
    {
        // Log message to console
        Debug.Log("Quit Game");
        // Quit the application
        Application.Quit();
    }
}
