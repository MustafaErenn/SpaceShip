using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreenScripts: MonoBehaviour
{
    public GameObject backToMenuWarning;
    public GameObject quitGameWarning;
    public GameObject olumEkraniArkaPlani;
    public GameObject shopMenuCanvas;



    void Start()
    {
       olumEkraniArkaPlani.SetActive(false);
        Time.timeScale = 1f;
    }

   
    void Update()
    {
        
    }


    public void restartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        Time.timeScale = 1f;
    }
    public void backToMenu()
    {
        olumEkraniArkaPlani.SetActive(false);
        backToMenuWarning.SetActive(true);
    }
    public void backToMenuYes()
    {
        SceneManager.LoadScene(0);
    }
    public void backToMenuNo()
    {
        backToMenuWarning.SetActive(false);
        olumEkraniArkaPlani.SetActive(true);
    }

    public void quitButton()
    {
        olumEkraniArkaPlani.SetActive(false);
        quitGameWarning.SetActive(true);
    }
    public void quitButtonYes()
    {
        Application.Quit();
        Debug.Log("quitting");
    }
    public void quitButtonNo()
    {
        quitGameWarning.SetActive(false);
        olumEkraniArkaPlani.SetActive(true);
    }

    public void ShopMenu()
    {
        shopMenuCanvas.SetActive(true);
        olumEkraniArkaPlani.SetActive(false);
    }
}
