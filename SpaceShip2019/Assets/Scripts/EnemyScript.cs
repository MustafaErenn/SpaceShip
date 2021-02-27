using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int maxHealth = 60;
    public int currentHealth;
   
    public bool isDead = false;
    
    public GameObject impectEffect;
    public Animator animator;
    
    

    void Start()
    {
        currentHealth = maxHealth;
       

    }

    // Update is called once per frame
    void Update()
    {
       // Destroy(GameObject.FindWithTag("Explosion"), 0.2f);

        
    }

   public void takeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {

            animator.SetBool("isDead", true);
            Debug.Log("im dead nigga");
            isDead = true;
            
            Destroy(gameObject,0.5f);
            
         
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Bullet"))
        {
            if(isDead==false)
            {
                SoundManager.PlaySound("HurtEnemy");
            }
            
            takeDamage(20);
            Destroy(collision.gameObject);
            /*if(currentHealth<=0)
            {
                
                Destroy(gameObject);
                //Instantiate(impectEffect, gameObject.transform.position, Quaternion.identity);
                

            }*/
           
        }
        if (collision.gameObject.tag == ("Player"))
        {
            
            takeDamage(20);


            //Destroy(collision.gameObject);
        }
    }
}
