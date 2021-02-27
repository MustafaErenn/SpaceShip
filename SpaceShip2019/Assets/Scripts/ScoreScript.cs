using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI moneyTextInShop;

    

    public GameObject player;
    public Player playerScript;
    public GameObject deathScreen;

    

    public ProgressBar progressBar;
    private int highScoreInt;


    public float score;
    public float money;
    public int totalMoney;
    private int sayac;
    

    void Start()
    {
        
        player = GameObject.Find("SpaceShipv1");
        playerScript = player.GetComponent<Player>();
       // progressBar.SetBeginingProgress(2000);

        highScoreText.text = PlayerPrefs.GetInt("HighestScore", 0).ToString();
        moneyText.text = PlayerPrefs.GetInt("TotalMoney", 0).ToString();

        sayac = 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if(player!=null)
        {

            Time.timeScale = 1f;
            score += Time.deltaTime * 20;
         //   money = score / 10;
            
            
            scoreText.text = score.ToString("0");
           // moneyText.text = money.ToString("0");
           
           // progressBar.SetProgress((int)score); // GERI ACMAN LAZIM


            if (score > PlayerPrefs.GetInt("HighestScore", 0))
            {
                highScoreInt = (int)score;
                PlayerPrefs.SetInt("HighestScore", highScoreInt);
                highScoreText.text = highScoreInt.ToString();
                
            }

            // totalMoney += (int)money;
            /* PlayerPrefs.SetInt("TotalMoney", totalMoney);
             moneyText.text = totalMoney.ToString();*/
            
        }

        /*if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log((totalMoney += (int)money));
            PlayerPrefs.SetInt("TotalMoney", totalMoney);
            moneyText.text = totalMoney.ToString();
        }*/
        if(player==null)
        {

            if (sayac >0)
            {

                Debug.Log("BIR KERE CALIS ALLAHIN CEZASI");
                money = score / 10;
                Debug.Log("BIR ONCEKI TOTAL MONEY  " + PlayerPrefs.GetInt("TotalMoney"));

                Debug.Log("YENI GELEN MONEY  " + money);

                totalMoney = (PlayerPrefs.GetInt("TotalMoney")) + (int)money;

                Debug.Log("GUNCELLENMIS TOTAL MONEY   " + totalMoney);

                PlayerPrefs.SetInt("TotalMoney", totalMoney);

                moneyText.text = totalMoney.ToString("0");
                moneyTextInShop.text = totalMoney.ToString("0");

                deathScreen.SetActive(true);
                Time.timeScale = 0f;
                sayac--;
            }
        }
        
       
    }
}
