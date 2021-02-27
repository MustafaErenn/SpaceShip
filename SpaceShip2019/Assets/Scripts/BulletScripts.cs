using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class BulletScripts : MonoBehaviour
{
    private float speed = 10f;
    
    
    private Rigidbody2D rb2d;
   


    void Start()
    {
        rb2d = this.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        
       // transform.Translate(transform.up* moveForce * Time.deltaTime);
        rb2d.MovePosition(transform.position + transform.up * speed * Time.fixedDeltaTime);


        Destroy(gameObject, 1f);
    }
}
