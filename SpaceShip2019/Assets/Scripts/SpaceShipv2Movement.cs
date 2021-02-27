using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipv2Movement : MonoBehaviour
{
    public float speed = 3f;
    float horizontalMove = 0f;

    private Rigidbody2D rb2d;

    public Joystick joystick;


    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        horizontalMove = joystick.Horizontal;
        

        rb2d.MovePosition((transform.position)*horizontalMove*speed);

    }
}
