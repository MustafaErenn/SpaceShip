using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacingPlayer : MonoBehaviour
{
    public GameObject player;

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        player = GameObject.Find("SpaceShipv1");
        rb = this.GetComponent<Rigidbody2D>();
        Vector3 direction = player.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
