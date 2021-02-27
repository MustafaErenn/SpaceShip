using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{

    

    public GameObject player;
    public float moveSpeed = 5f;
    private Rigidbody2D rb2d;
    private Vector2 movement;
    public EnemyScript enemyScript;
    public float currentEnemyHealth;
    public bool isDeadBool = false;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        player = GameObject.Find("SpaceShipv1");
        enemyScript = gameObject.GetComponent<EnemyScript>();
    }
    private void FixedUpdate()
    {
        Vector3 direction = player.transform.position - transform.position;
        /*float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb2d.rotation = angle;*/
        direction.Normalize();
        movement = direction;


        currentEnemyHealth = enemyScript.currentHealth;

        if (!(isEnemyDead(currentEnemyHealth))   )
        {
            moveCharacter(movement);
        }

    }
    /*private void Update()
    {
       if( !isEnemyDead(currentEnemyHealth) )
        {
            moveCharacter(movement);
        }
        
    
    }*/
    void moveCharacter(Vector2 direction)
    {
        rb2d.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
    bool isEnemyDead(float currentEnemyHealth)
    {
        
        if (currentEnemyHealth<=0)
        {
            isDeadBool = true;
              
        }
        return isDeadBool;  
    }
}
