using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchScreenForMoving : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb2d;

    private Vector2 screenBounds;
    private bool movingForward;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));


    }

    void Update()
    {
        if(Input.touchCount > 0)
        {
            Debug.Log("hello world!");
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            
                if(touchPosition.x>screenBounds.x/2 && touchPosition.y<screenBounds.y     )
             {

                 transform.Translate(Vector2.up * speed * Time.deltaTime);
             }


        }


        //BUDA MOUSELA TEST ETMEK ICIN YAZILAN KOD
      /* if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Debug.Log("kocum!");
            if (mousePosition.x > screenBounds.x / 2 && mousePosition.y < screenBounds.y)
                {
                Debug.Log("hareket etsene kocum!");
                    transform.Translate(Vector2.up * speed * Time.deltaTime);
                }
            

        }*/


    }


    //BUNLAR SUAN GEREKSİZ
    public void movingButtonPressed()
    {
        movingForward = true;

    }
    public void movingButtonReleased()
    {
        movingForward = false;

    }
}
