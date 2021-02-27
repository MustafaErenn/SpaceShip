using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopMenuScript : MonoBehaviour
{

    public GameObject player;
    public Player playerScript;
    public TextMeshProUGUI maxHealth;

    public GameObject ScoreController;
    public ScoreScript scoreScript;

    public GameObject ShopMenu;
    public GameObject olumEkraniArkaPlani;

    public GameObject purchaseSuccesful;
    public GameObject purchaseFailed;
    public GameObject shopMenuExceptPanel;


    public int newMaxHealth;

    void Start()
    {
        ShopMenu.SetActive(false);
        player = GameObject.Find("SpaceShipv1");//bunu duzelt

        playerScript = player.GetComponent<Player>();

        newMaxHealth = playerScript.maxHealth;

        ScoreController = GameObject.Find("ScoreController");
        scoreScript = ScoreController.GetComponent<ScoreScript>();
       
       
        maxHealth.text = PlayerPrefs.GetInt("MaxHealth", playerScript.maxHealth).ToString();
        playerScript.maxHealth = PlayerPrefs.GetInt("MaxHealth", 200);
        // playerScript.maxHealth = PlayerPrefs.GetInt("MaxHealth", playerScript.maxHealth);
        Debug.Log("player max health =" + playerScript.maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(PlayerPrefs.GetInt("TotalMoney"));
    }

    public void HealthUpdate()
    {

        if (PlayerPrefs.GetInt("TotalMoney") >= 200)
        {
            newMaxHealth = playerScript.maxHealth + 100;//canına yuz ekliyor
            playerScript.maxHealth = newMaxHealth;
            PlayerPrefs.SetInt("MaxHealth", newMaxHealth);

            //maxHealth.text = newMaxHealth.ToString();//test icin

            PlayerPrefs.SetInt("TotalMoney", (PlayerPrefs.GetInt("TotalMoney") - 200));
            scoreScript.moneyText.text = (PlayerPrefs.GetInt("TotalMoney").ToString());
            Debug.Log("satın alma başarılı şuanki can degeri = " + PlayerPrefs.GetInt("MaxHealth"));
            shopMenuExceptPanel.SetActive(false);
            purchaseSuccesful.SetActive(true);
        }
        else
        {
            shopMenuExceptPanel.SetActive(false);
            purchaseFailed.SetActive(true);
        }
        
    }
    public void backButton()
    {
        ShopMenu.SetActive(false);
        olumEkraniArkaPlani.SetActive(true);
    }

    public void purchaseFailedOkButton()
    {
        purchaseFailed.SetActive(false);
        shopMenuExceptPanel.SetActive(true);
    }
    public void purchaseSuccesfulOkButton()
    {
        purchaseSuccesful.SetActive(false);
        shopMenuExceptPanel.SetActive(true);
    }
}
