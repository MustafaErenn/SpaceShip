using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectionMenuScript : MonoBehaviour
{

    public GameObject panel;
    public GameObject Border;
    public GameObject normalModeButton;
    public GameObject infiniteModeButton;
    public GameObject backToMenuButton;
    public GameObject backToMenuWarning;


    void Start()
    {
        
    }

    public void normalModeButtonFonk()
    {
        //simdilik bir sey yok
    }
    public void infiniteModeButtonFonk()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void backToMenuButtonFonk()
    {
        //panel.SetActive(false);
        Border.SetActive(false);
        normalModeButton.SetActive(false);
        infiniteModeButton.SetActive(false);
        backToMenuButton.SetActive(false);

        backToMenuWarning.SetActive(true);
    }

    public void backToMenuButtonFonkYes()
    {
        SceneManager.LoadScene(0);
    }
    public void backToMenuButtonFonkNo()
    {
       // panel.SetActive(true);
        Border.SetActive(true);
        normalModeButton.SetActive(true);
        infiniteModeButton.SetActive(true);
        backToMenuButton.SetActive(true);

        backToMenuWarning.SetActive(false);
    }

}
