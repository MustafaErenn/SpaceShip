using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public GameObject pauseMenu;
    public GameObject RestartSignForSure;
    public GameObject BackToMenuSignForSure;
    public GameObject QuitSignForSure;
    public bool isPaused;

    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseGameButton()
    {
        PauseGame();
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        if(isPaused)
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
        }
        isPaused = false;
        
        
    }

    public void BackToMenu()
    {
        BackToMenuSignForSure.SetActive(true);
        pauseMenu.SetActive(false);
    }
    public void BackToMenuQuestionYes()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    public void BackToMenuQuestionNo()
    {
        BackToMenuSignForSure.SetActive(false);
        pauseMenu.SetActive(true);
            
    }

    public void RestartButton()
    {
        RestartSignForSure.SetActive(true);
        pauseMenu.SetActive(false);
    }
    public void RestartQuestionYes()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
    public void RestartQuestionNo()
    {
        RestartSignForSure.SetActive(false);
        pauseMenu.SetActive(true);
    }
    public void QuitGame()
    {
        QuitSignForSure.SetActive(true);
        pauseMenu.SetActive(false);
    }
    public void QuitQuestionYes()
    {
        Time.timeScale = 1f;
        Application.Quit();
        Debug.Log("quitting");
    }
    public void QuitQuestionNo()
    {
        QuitSignForSure.SetActive(false);
        pauseMenu.SetActive(true);
    }
}
