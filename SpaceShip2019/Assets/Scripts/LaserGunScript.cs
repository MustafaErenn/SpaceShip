using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserGunScript : MonoBehaviour
{

    public BoxCollider2D boxCollider2d;
    private Vector2 screenBounds;
    public SpriteRenderer spriteRenderer;
    
    private float oldColliderSizeX;

    private bool isPlayed;
    
    void Start()
    {
        boxCollider2d = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

        oldColliderSizeX = boxCollider2d.size.x;

        isPlayed = false;
    }

    
    void Update()
    {
       if( spriteRenderer.sprite.name== "LaserAnimLong-11")
        {
             boxCollider2d.size = new Vector2(screenBounds.x, boxCollider2d.size.y);
            if(!isPlayed)
            {
               
                SoundManager.PlaySound("LaserGun6");
                isPlayed = true;
            }
            
        }
        else
        {
            boxCollider2d.size = new Vector2(oldColliderSizeX, boxCollider2d.size.y);
        }
    }

   

}
