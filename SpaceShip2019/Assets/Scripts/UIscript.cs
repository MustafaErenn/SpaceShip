using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIscript : MonoBehaviour
{
    private float playerScore = 0;
    
    
    public Player playerScript;

   /* public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;*/


    public GameObject player;
    public ProgressBar progressBar;
    private int highScoreInt;

    
    public Text scoreText;
    public Text highScoreText;


    public TextMeshProUGUI scoreTextv2;
    public TextMeshProUGUI highScoreTextv2;
    public float playerScorev2=0;

    public GameObject deathScreen;
    




    void Start()
    {
        player = GameObject.Find("SpaceShipv1");
        playerScript = player.GetComponent<Player>();
        progressBar.SetBeginingProgress(2000);


         //  scoreText = GetComponent<TextMeshProUGUI>();
        //   highScoreText = GetComponent<TextMeshProUGUI>();
        scoreTextv2 = GetComponent<TextMeshProUGUI>();
        highScoreTextv2 = GetComponent<TextMeshProUGUI>();


       highScoreText.text = PlayerPrefs.GetInt("HighestScore", 0).ToString();
           //highScoreTextv2.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
       if (player != null)
        {
            playerScore += Time.deltaTime * 20;
            scoreText.text = playerScore.ToString("0");
            scoreTextv2.text = playerScore.ToString("0");
            progressBar.SetProgress((int)playerScore);
            Debug.Log(playerScore);



            if (playerScore > PlayerPrefs.GetInt("HighestScore", 0))
            {
                highScoreInt = (int)playerScore;
                PlayerPrefs.SetInt("HighestScore", highScoreInt);
                highScoreText.text = highScoreInt.ToString();
                //Debug.Log(highScoreInt);


            }


        }

        if(player==null)
        {
            deathScreen.SetActive(true);


        }



      /*  if(playerScript.currentHealth>0)
        {
            playerScorev2 += Time.deltaTime * 20;

            if (playerScorev2 > PlayerPrefs.GetInt("HighScore", 0))
            {
                highScoreInt = (int)playerScorev2;
                PlayerPrefs.SetInt("HighScore", highScoreInt);
                

            }
        }

        if(playerScript.currentHealth<=0 && deathScreen!=null)
        {
            Debug.Log("annesini sikiyim yeter artık");
            Debug.Log(playerScorev2);
            scoreTextv2.text = playerScorev2.ToString("0");
            highScoreTextv2.text = highScoreInt.ToString();
            //Debug.Log(scoreTextv2);
            
        }

        */





    }
    }
