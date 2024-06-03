using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool Paused = false;
    public GameObject pauseMenuUI;

    // Start is called before the first frame update
    private void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(Paused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    private void Stop()
    {
        pauseMenuUI.SetActive(true);
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;  // Resume normal time scale
        Paused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;  // Pause the game time
        Paused = true;
    }

    public void Options()
    {
        Debug.Log("Options button clicked"); 
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;  // Make sure the game's time scale is reset
        SceneManager.LoadScene("MainMenu");  // Load the Main Menu scene
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    
}
