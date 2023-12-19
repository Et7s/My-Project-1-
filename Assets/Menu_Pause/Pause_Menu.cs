using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_Menu : MonoBehaviour
{
    public static bool GameisPaused = false;

    public GameObject pauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameisPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
    }
    private void Pause()
    {
        pauseMenuUI.SetActive(true); 
        Time.timeScale = 0f;
        GameisPaused = true;
    }
    public void LoadMenu()
    {
        Application.LoadLevel("Menu");
    }
}
