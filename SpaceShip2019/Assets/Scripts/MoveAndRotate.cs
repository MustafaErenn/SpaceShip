using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class MoveAndRotate : MonoBehaviour
{
    public float moveForce = 5;
   public Rigidbody2D rb2d;
    public float speed = 5f;
    public Vector2 moveVelocity;
    public Vector3 lookVector;
    
    void Start()
    {
        rb2d = this.GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        
    }


    void FixedUpdate()
    {
        
        //lookVector = new Vector3(CrossPlatformInputManager.GetAxisRaw("Horizontal_2"), CrossPlatformInputManager.GetAxisRaw("Vertical_2"), 5000) * moveForce; 
        // ustteki lookVector hem hem ilerlemeye hemde rotate etmeye yariyor.
        lookVector = new Vector3(CrossPlatformInputManager.GetAxisRaw("Horizontal_2"), CrossPlatformInputManager.GetAxisRaw("Vertical_2"), 5000) * moveForce;
        
        if (lookVector.x != 0 && lookVector.y != 0)
        {
            transform.rotation = Quaternion.LookRotation(lookVector, Vector3.back);
            
        }
        moveVelocity = lookVector ;
        //Debug.Log(moveVelocity.y);

        /* if (moveVelocity.y > -2f && moveVelocity.y < 2f)
         {
             moveVelocity.y = 0;
         }*/
        
       /*  else if (moveVelocity.y < -1f)
         {

             moveVelocity.y = -5f;

         }
         else if (moveVelocity.y > 1f)
         {
             moveVelocity.y = 5f;
         }*/

        /*if (moveVelocity.x > -2f && moveVelocity.x < 2f)
         {
             moveVelocity.x = 0;
         }*/
        
        /* else if (moveVelocity.x < -1f)
         {
             moveVelocity.x = -5f;
         }
         else if (moveVelocity.x > 1f)
         {
             moveVelocity.x = 5f;
         }*/
        //moveVelocity = lookVector;


        /*if((moveVelocity.y > -0.5f && moveVelocity.y < 0.5f) || (moveVelocity.x > -0.5f && moveVelocity.x < 0.5f)  )
        {
            //rb2d.MovePosition(rb2d.position + moveVelocity * Time.fixedDeltaTime);
            Debug.Log("HAREKET ETMEMEMEN LAZIM LAN !");
        }
        else
        {
            
            rb2d.MovePosition(rb2d.position + moveVelocity * Time.fixedDeltaTime);
        }*/

       //rb2d.MovePosition(rb2d.position + moveVelocity * Time.fixedDeltaTime);
       // rb2d.MovePosition(rb2d.position + moveVelocity * Time.fixedDeltaTime);



    }
    public void moveButton()
    {
        
        rb2d.MovePosition(rb2d.position *speed * Time.fixedDeltaTime);
        Debug.Log("calisiyorum!");
    }
    

}
