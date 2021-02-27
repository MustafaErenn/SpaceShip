using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DENEME : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb2d;
    private bool movingForward;
    public GameObject firePoint1;
    public GameObject firePoint2;

    public GameObject jetFirePrefab;// ucagın çalısırken altından çıkıcak ateş

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        firePoint1 = GameObject.Find("FirePoint1");
        firePoint2 = GameObject.Find("FirePoint2");

        
    }
    private void Update()
    {
       /* Instantiate(jetFirePrefab, firePoint1.transform.position, Quaternion.identity);
        Instantiate(jetFirePrefab, firePoint2.transform.position, Quaternion.identity);*/
        if (movingForward)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
    }
    public void movingButtonPressed()
    {
        movingForward = true;
           
    }
    public void movingButtonReleased()
    {
        movingForward = false;

    }
}
