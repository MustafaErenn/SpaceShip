using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    public GameObject DeathScreen;

    public GameObject shopMenuController;// scenede shop menu diye bir sey olusturman lazım
    public ShopMenuScript shopMenuScript;

    public TextMeshProUGUI playerMaxHealth;// gereksiz, test icin




    public CameraShake cameraShake;

    void Start()
    {

        shopMenuController = GameObject.Find("ShopMenuController");
        shopMenuScript = shopMenuController.GetComponent<ShopMenuScript>();

        //maxHealth = shopMenuScript.newMaxHealth;
        maxHealth = PlayerPrefs.GetInt("MaxHealth");

        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

       
        
    }

    // Update is called once per frame
    void Update()
    {
        playerMaxHealth.text = maxHealth.ToString();//gereksiz, test icin
    }
    

    void takeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            // Destroy(gameObject);
            //SceneManager.LoadScene(0);
            Destroy(gameObject);

            


        }
        healthBar.SetHealth(currentHealth);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag==("Enemy"))
        {
            SoundManager.PlaySound("HurtPlayer");
            cameraShake.ShakeIt();
            takeDamage(20);
            
        }
        if(collision.gameObject.tag==("LaserGun"))
        {
            takeDamage(50);
            cameraShake.ShakeIt();
            SoundManager.PlaySound("HurtPlayer");
             
        }
    }
}
